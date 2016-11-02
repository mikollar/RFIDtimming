using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDTimming.Models
{

    class CategoryStart
    {
        public bool Start { get; set; }

        public string CategoryID { get; set; }

        public string CategoryName { get; set; }
    }

    class CategoryTime
    {
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }

        public TimeSpan Time { get; set; }
    }

}
