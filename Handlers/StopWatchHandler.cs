using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RFIDTimming.Handlers
{
    class StopWatchHandler
    {
        private DateTime StartTime { get; set; }
        private bool Running { get; set; }

        /// <summary>
        /// Start stopwatch
        /// </summary>
        public void Start()
        {
            // if already running, do nothing
            if(this.Running)
            {
                return;
            }

            // set start time
            this.StartTime = DateTime.Now;
        }

    }
}
