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
        Enums.Enums.RFIDMode RFIDMode = Enums.Enums.RFIDMode.OFF;  

        public RFIDHandler(E_Events ev, Context context)
            : base(ev != null ? (int?)ev.EventID : null, context)
        {
        }

        // Create an instance of the ImpinjReader class.
        static ImpinjReader reader = new ImpinjReader();

        /// <summary>
        /// Init RFID
        /// </summary>
        public static void InitRFID()
        {
            
            // to the IP address or hostname of your reader.
            reader.Connect("192.168.1.101", 5084);


            reader.TagsReported += Reader_TagsReported;
            reader.ResumeEventsAndReports();
        }

        /// <summary>
        /// Read tag event
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="report"></param>
        private static void Reader_TagsReported(ImpinjReader reader, TagReport report)
        {
            foreach (var tag in report.Tags)
            {
                Console.WriteLine(tag.LastSeenTime.LocalDateTime.ToShortTimeString() + " " + tag.Epc + " " + tag.ChannelInMhz);
            }

        }

        /// <summary>
        /// Get start numbers with tag
        /// </summary>
        /// <returns></returns>
        public List<E_NumberTag> GetStartNumbers()
        {
           return this.Context.E_NumberTag.OrderBy(o => o.BibNumber).ToList();
        }
    }
}
