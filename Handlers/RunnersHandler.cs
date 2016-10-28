using Impinj.OctaneSdk;
using RFIDTimming.Data;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RFIDTimming.Handlers
{

    class RunnersHandler : BaseHandler
    {
        public RunnersHandler(E_Events ev) : base(ev != null ? (int?)ev.EventID : null)
        {
        }

        public RunnersHandler(E_Events ev, Context context)
            : base(ev != null ? (int?)ev.EventID : null, context)
        {
        }

        /// <summary>
        /// Get all runners
        /// </summary>
        /// <returns></returns>
        public List<E_Runners> GetRunners()
        {
            return this.Context.E_Runners.AsNoTracking().Where(x => x.EventID == this.ActiveEventID).OrderBy(o => o.Surname).ToList();
        }

        /// <summary>
        /// Get runner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public E_Runners GetRunner(int id, bool asNoTracking)
        {
            if(asNoTracking == false)
            {
                return this.Context.E_Runners.FirstOrDefault(x => x.RunnerID == id && x.EventID == this.ActiveEventID);
            }
            else
            {
                return this.Context.E_Runners.AsNoTracking().FirstOrDefault(x => x.RunnerID == id && x.EventID == this.ActiveEventID);
            }
        }

        /// <summary>
        /// Create update runner
        /// </summary>
        /// <param name="runnerID"></param>
        /// <param name="name"></param>
        /// <param name="categoryCode"></param>
        /// <param name="club"></param>
        /// <param name="startNumber"></param>
        /// <returns></returns>
        public string CreateUpdateRunner(int runnerID, string name, string categoryCode, int? clubID, string club, string startNumber, string resultTime, out E_Runners runner)
        {
            runner = null;
            // check if start number is already assigned
            if(!string.IsNullOrEmpty(startNumber))
            {
                if (this.Context.E_Runners.Count(x => x.EventID == this.ActiveEventID && x.StartNumber == startNumber && x.RunnerID != runnerID) > 0)
                {
                    return "Startovne cislo ma prideleny iny pretekar";
                }
            }

            // start transaction
            using (var dbContextTransaction = this.Context.Database.BeginTransaction())
            {
                // create club if not exist
                if ((clubID == null || clubID == 0) && !string.IsNullOrEmpty(club))
                {
                  clubID = this.CreateUpdateClub(0, club);
                }

                // get runner
                runner = this.GetRunner(runnerID, false);
                // create if not exist
                if (runner == null)
                {
                    this.Context.E_Runners.Add(new E_Runners
                    {
                        EventID = this.ActiveEventID.Value,
                        Surname = name,
                        StartNumber = startNumber,
                        CategoryID = categoryCode,
                        ClubID = clubID,
                    });

                    this.Context.SaveChanges();
                }
                else
                {
                    TimeSpan _resultTime;

                    resultTime = (resultTime ?? "").Trim();

                    if (TimeSpan.TryParseExact(resultTime, "h\\:mm\\:ss", CultureInfo.InvariantCulture, out _resultTime))
                    {
                        runner.ResultTime = _resultTime;
                    }

                    runner.Surname = name;
                    runner.StartNumber = startNumber;
                    runner.CategoryID = categoryCode;
                    runner.ClubID = clubID;

                    this.Context.SaveChanges();
                }

                // commit transaction
                dbContextTransaction.Commit();
            }


            return string.Empty;
        }

        /// <summary>
        /// Delete runner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteRunner(int id)
        {
            var runner = this.GetRunner(id, false);
            // check if is used
            if(runner == null)
            {
                return "Pretekar nenajdeny!";
            }

            this.Context.E_Runners.Remove(runner);

            this.Context.SaveChanges();

            return string.Empty;
        }

        /// <summary>
        /// Get all clubs
        /// </summary>
        /// <returns></returns>
        public List<E_Club> GetClubs()
        {
            return this.Context.E_Club.AsNoTracking().Where(x => x.EventID == this.ActiveEventID).OrderBy(o => o.Name).ToList();
        }

        /// <summary>
        /// Get club
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public E_Club GetClub(int id, bool asNoTracking)
        {
            if (asNoTracking == false)
            {
                return this.Context.E_Club.FirstOrDefault(x => x.ClubID == id && x.EventID == this.ActiveEventID);
            }
            else
            {
                return this.Context.E_Club.AsNoTracking().FirstOrDefault(x => x.ClubID == id && x.EventID == this.ActiveEventID);
            }
        }

        /// <summary>
        /// Create update club
        /// </summary>
        /// <param name="clubID"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int CreateUpdateClub(int clubID, string name)
        {
            // get runner
            var runner = this.GetClub(clubID, false);
            // create if not exist
            if (runner == null)
            {
                runner = new E_Club
                 {
                     EventID = this.ActiveEventID.Value,
                     Name = name,
                 };

                this.Context.E_Club.Add(runner);

                this.Context.SaveChanges();
            }
            else
            {
                runner.Name = name;

                this.Context.SaveChanges();
            }

            return runner.ClubID;
        }

        /// <summary>
        /// Delete club
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteClub(int id)
        {
            var runner = this.GetClub(id, false);
            // check if is used
            if (runner == null)
            {
                return "Klub nenajdeny!";
            }

            if(this.Context.E_Runners.Count(x => x.EventID == this.ActiveEventID && x.ClubID == runner.ClubID) > 0)
            {
                return "Pretekár ma priradený tento klub! Vymaz nie je možný";
            }

            this.Context.E_Club.Remove(runner);

            this.Context.SaveChanges();

            return string.Empty;
        }
    }
}
