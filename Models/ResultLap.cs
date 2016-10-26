using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDTimming.Models
{
    class ResultLap
    {
        public string Category { get; set; }
        public string Club { get; set; }
        public string Place { get; set; }
        public string Name { get; set; }
        public Dictionary<int, TimeSpan> Laps { get; set; }

        public TimeSpan? ResultTime { get; set; }

    }

}
