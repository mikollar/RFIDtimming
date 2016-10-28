using Impinj.OctaneSdk;
using RFIDTimming.Data;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using RFIDTimming.Enums;

namespace RFIDTimming.Handlers
{
   
    class RFIDHandler : BaseHandler
    {
        Queue<TagReport> ReadedTagsQueue = new Queue<TagReport>();

        Enums.Enums.RFIDMode RFIDMode = Enums.Enums.RFIDMode.OFF;
        Func<RFIDRead, int> ReadRFIDCallback = null;
        int FirstStartNumber = 1;
        E_Events ActiveEvent = null;

        public RFIDHandler(E_Events ev, Context context)
            : base(ev != null ? (int?)ev.EventID : null, context)
        {
        }

        // Create an instance of the ImpinjReader class.
        static ImpinjReader reader = new ImpinjReader();

        /// <summary>
        /// Init RFID
        /// </summary>
        public string InitRFID(Func<RFIDRead, int> readRFIDCallBack)
        {
            this.ReadRFIDCallback = readRFIDCallBack;
            // clear queue
            this.ReadedTagsQueue = new Queue<TagReport>();

            try
            {
                // if reader is not connected
                if (reader != null && reader.IsConnected == false)
                {
                    // to the IP address or hostname of your reader.
                    reader.Connect("192.168.1.101", 5084);

                    // add disconnect event
                    reader.DirectionReported += Reader_DirectionReported;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

          
            //reader.ApplyDefaultSettings();
            //reader.ApplySettings();
          //  reader.SaveSettings();
            // add read tag event
            reader.TagsReported += Reader_TagsReported;
            // resume tag reads
            reader.ResumeEventsAndReports();

            return string.Empty;
        }

        /// <summary>
        /// RFID reader disconnect event
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="report"></param>
        private void Reader_DirectionReported(ImpinjReader reader, DirectionReport report)
        {
            // init RFID
            this.InitRFID(this.ReadRFIDCallback);
        }


        private static object lockObj = new object();
        private static object lockObjQueue = new object();
        /// <summary>
        /// Read tag event
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="report"></param>
        private void Reader_TagsReported(ImpinjReader reader, TagReport report)
        {
            lock (lockObjQueue)
            {
                // add to FIFO
                this.ReadedTagsQueue.Enqueue(report);
            }
        }

        /// <summary>
        /// Process readed tags
        /// </summary>
        public void ProcessReadedTags()
        {
            List<TagReport> tagReports = null;

            // check if queue has items
            if(this.ReadedTagsQueue.Count == 0)
            {
                return;
            }

            var internalContext = new Context();

            // get all categories
            var categories = internalContext.E_Category.AsNoTracking().ToList();

            lock (lockObjQueue)
            {
                // copy queue
                tagReports = this.ReadedTagsQueue.ToArray().ToList();
                // clear queue
                this.ReadedTagsQueue.Clear();
            }

            // group same tags, get first time
            var groupedRead = tagReports.SelectMany(s => s.Tags)
                                                 .GroupBy(grp => grp.Epc)
                                                 .Select(s => new
                                                 {
                                                     FirstSeenTime = s.Min(m => m.FirstSeenTime),
                                                     Epc = s.Min(m => m.Epc),
                                                     Tid = s.Min(m => m.Tid),
                                                     Anntena = s.Min(m => m.AntennaPortNumber)
                                                 });


            // loop queue
            foreach (var tag in groupedRead)
            {
                RFIDRead returnRead = new RFIDRead();

                var readedTag = new R_TagRead
                {
                    ReadTime = tag.FirstSeenTime.LocalDateTime.TimeOfDay,
                    TagID = tag.Epc.ToString(),
                    UserData = tag.Tid.ToString(),
                    Antenna = tag.Anntena,
                };

                returnRead.Tag = readedTag;

                // find assigned number to tag
                var assignedNumber = internalContext.E_NumberTag
                                                    .AsNoTracking()
                                                    .FirstOrDefault(x => x.TagID == readedTag.TagID);

                if (assignedNumber != null)
                {
                    returnRead.StartNumber = assignedNumber.BibNumber;
                }

                // do nothing
                if (this.RFIDMode == Enums.Enums.RFIDMode.OFF)
                {
                }
                // just show Start number assigned to tag
                else if (this.RFIDMode == Enums.Enums.RFIDMode.TEST)
                {
                }
                // assign tag to start number
                else if (this.RFIDMode == Enums.Enums.RFIDMode.ASSIGN)
                {
                    #region ASSIGN mode
                    if (assignedNumber != null)
                    {
                        returnRead.Error = "Čip už ma priradené štartovné číslo " + assignedNumber.BibNumber;
                    }
                    else
                    {
                        internalContext.E_NumberTag.Add(new E_NumberTag
                        {
                            BibNumber = this.FirstStartNumber.ToString(),
                            TagID = readedTag.TagID,
                        });
                        internalContext.SaveChanges();

                        // move to next number
                        this.FirstStartNumber++;

                        returnRead.NextAssignNumber = this.FirstStartNumber;
                    }
                    #endregion
                }
                // read tag an write to table
                else if (this.RFIDMode == Enums.Enums.RFIDMode.READ && this.ActiveEventID.HasValue)
                {
                    lock (lockObj)
                    {
                        // try get runner
                        if (!string.IsNullOrEmpty(returnRead.StartNumber))
                        {
                            returnRead.Runner = internalContext.E_Runners.FirstOrDefault(x => x.EventID == this.ActiveEventID && x.StartNumber == returnRead.StartNumber);
                        }

                        readedTag.EventID = this.ActiveEventID.Value;

                        // check if tag was already read in last 10s
                        var lastTag = internalContext.R_TagRead.OrderByDescending(o => o.ReadTime).FirstOrDefault(x => x.TagID == readedTag.TagID);

                        // save same tag only every 10 seconds or if runner has category only min category lap time
                        if (lastTag == null || (DateTime.Now.TimeOfDay - lastTag.ReadTime).TotalSeconds > 10)
                        {
                            // get runner category
                            E_Category runnerCat = null;
                            if (returnRead.Runner != null)
                            {
                                runnerCat = categories.FirstOrDefault(x => x.EventID == this.ActiveEventID && x.CategoryID == returnRead.Runner.CategoryID);
                            }

                            if (returnRead.Runner != null && runnerCat != null)
                            {
                                // calculate category start time
                                var categoryStartTime = this.ActiveEvent.EventDateTime.TimeOfDay + TimeSpan.FromSeconds(runnerCat.OffsetStartTime);

                                // if runner has category, write tag read only if minimum time for lap elpased after previous tag read
                                if (lastTag == null || runnerCat == null || ((DateTime.Now.TimeOfDay - lastTag.ReadTime).TotalSeconds > runnerCat.MinLapTime && categoryStartTime <= DateTime.Now.TimeOfDay))
                                {
                                    if (categoryStartTime <= readedTag.ReadTime)
                                    {
                                        // save tag read to DB
                                        internalContext.R_TagRead.Add(readedTag);
                                        // save to DB
                                        internalContext.SaveChanges();

                                        // find first possible lap time for current tag
                                        var firstPossibleLapTime = categoryStartTime + TimeSpan.FromSeconds(runnerCat.MinLapTime);

                                        // count laps, tag reads lates as category start time
                                        var lapsCount = internalContext.R_TagRead
                                                                        .AsNoTracking()
                                                                        .Count(x => x.EventID == this.ActiveEventID &&
                                                                                    x.TagID == readedTag.TagID &&
                                                                                    x.ReadTime >= firstPossibleLapTime);

                                        if(lapsCount <= runnerCat.Laps)
                                        {
                                            returnRead.Lap = lapsCount;
                                        }

                                        // calculate runner result time
                                        var resultTime = readedTag.ReadTime - categoryStartTime;

                                        // if runner finish last lap
                                        if (lapsCount == runnerCat.Laps && resultTime.TotalSeconds > 0)
                                        {
                                            returnRead.Runner.FinishTime = readedTag.ReadTime;
                                            returnRead.Runner.ResultTime = resultTime;

                                            returnRead.Finish = true;

                                            // save to DB
                                            internalContext.SaveChanges();
                                        }

                                    }
                                }
                            }
                        }
                    }
                }

                if (this.ReadRFIDCallback != null)
                {
                    this.ReadRFIDCallback(returnRead);
                }

                Console.WriteLine(tag.FirstSeenTime.LocalDateTime.ToShortTimeString() + " " + tag.Epc + " ");
            }
        }
        

        /// <summary>
        /// Set RFID mode
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="ev"></param>
        public void SetRfidMode(Enums.Enums.RFIDMode mode, E_Events ev, int firstStartNumber = 1)
        {
            this.RFIDMode = mode;

            if (ev != null)
            {
                this.ActiveEventID = ev.EventID;
                this.ActiveEvent = ev;
            }
            else
            {
                this.ActiveEvent = null;
                this.ActiveEventID = null;
            }

            this.FirstStartNumber = firstStartNumber;
        }

        /// <summary>
        /// Return RFID mode
        /// </summary>
        /// <returns></returns>
        public Enums.Enums.RFIDMode GetRfidMode()
        {
            return this.RFIDMode;
        }

        /// <summary>
        /// Get start numbers with tag
        /// </summary>
        /// <returns></returns>
        public List<E_NumberTag> GetStartNumbers()
        {
           return new Context().E_NumberTag.OrderBy(o => o.BibNumber).ToList();
        }

        /// <summary>
        /// Get connection status for RFID reader
        /// </summary>
        /// <returns></returns>
        public bool IsRfidConnected()
        {
            if(reader == null)
            {
                return false;
            }

            return reader.IsConnected;
        }
    }
}
