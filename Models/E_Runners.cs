using System;
using System.Collections.Generic;

namespace RFIDTimming.Models
{
    public partial class E_Runners
    {
        public int RunnerID { get; set; }
        public Nullable<int> EventID { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }

        public string StartNumber { get; set; }

        public string CategoryID { get; set; }

        public TimeSpan? FinishTime { get; set; }
        public TimeSpan? ResultTime { get; set; }
    }
}
