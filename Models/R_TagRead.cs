using System;
using System.Collections.Generic;

namespace RFIDTimming.Models
{
    public partial class R_TagRead
    {
        public int ReadID { get; set; }
        public int EventID { get; set; }
        public string TagID { get; set; }
        public string UserData { get; set; }
        public System.DateTime ReadTime { get; set; }
    }
}
