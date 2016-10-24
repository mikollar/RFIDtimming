using System;
using System.Collections.Generic;

namespace RFIDTimming.Models
{
    public partial class E_Category
    {
        public string CategoryID { get; set; }
        public int EventID { get; set; }
        public string CategoryName { get; set; }
        public int Laps { get; set; }
        public int MinLapTime { get; set; }
        public int OffsetStartTime { get; set; }
    }
}
