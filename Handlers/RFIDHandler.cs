using Impinj.OctaneSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RFIDTimming.Handlers
{

    class RFIDHandler
    {
        // Create an instance of the ImpinjReader class.
        static ImpinjReader reader = new ImpinjReader();

        public static void InitRFID()
        {
            
            // to the IP address or hostname of your reader.
            reader.Connect("192.168.1.101", 5084);


            reader.TagsReported += Reader_TagsReported;
            reader.ResumeEventsAndReports();
        }

        private static void Reader_TagsReported(ImpinjReader reader, TagReport report)
        {
            foreach (var tag in report.Tags)
            {
                Console.WriteLine(tag.LastSeenTime.LocalDateTime.ToShortTimeString() + " " + tag.Epc + " " + tag.ChannelInMhz);
            }

        }
    }
}
