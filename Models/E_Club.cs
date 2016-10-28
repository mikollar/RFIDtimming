using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RFIDTimming.Models
{
    public partial class E_Club
    {
        public int ClubID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }

    }
}
