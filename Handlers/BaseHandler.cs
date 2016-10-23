using Impinj.OctaneSdk;
using RFIDTimming.Data;
using RFIDTimming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RFIDTimming.Handlers
{

    class BaseHandler
    {
        public int? ActiveEventID { get; set; }
        public Context Context { get; set; }

        public BaseHandler(int? eventID) : this(eventID, new Context())
        {
        }

        public BaseHandler(int? eventID, Context context)
        {
            this.ActiveEventID = eventID;
            this.Context = context;
        }

   

    }
}
