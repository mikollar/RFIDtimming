﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDTimming.Models
{

    class RFIDRead
    {
        public E_Runners Runner { get; set; }
        public R_TagRead Tag { get; set; }

        public string StartNumber { get; set; }

        public int Lap { get; set; }

        public TimeSpan? LapTime { get; set; }

        public int? NextAssignNumber { get; set; }

        public bool Finish { get; set; }

        public string Error { get; set; }
    }

   
}
