using System;
using System.Collections.Generic;

namespace RFIDTimming.Models
{
    public partial class E_Category
    {
        public int CategoryID { get; set; }
        public int EventID { get; set; }
        public string CategoryName { get; set; }
        public int Laps { get; set; }
        public TimeSpan MinLapTime { get; set; }
        public TimeSpan OffsetStartTime { get; set; }
    }
}
