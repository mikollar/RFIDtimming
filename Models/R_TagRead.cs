using System;
using System.Collections.Generic;

namespace RFIDTimming.Models
{
    public partial class R_TagRead
    {
        public int ReadID { get; set; }
        public int EventID { get; set; }
        public string TagID { get; set; }
        public string TagHexString { get; set; }
        public string UserData { get; set; }
        public TimeSpan ReadTime { get; set; }

        public int Antenna { get; set; }
    }
}
