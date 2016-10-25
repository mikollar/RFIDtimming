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

    class RunnersHandler : BaseHandler
    {
        public RunnersHandler(E_Events ev) : base(ev != null ? (int?)ev.EventID : null)
        {
        }

        public RunnersHandler(E_Events ev, Context context)
            : base(ev != null ? (int?)ev.EventID : null, context)
        {
        }

        /// <summary>
        /// Get all runners
        /// </summary>
        /// <returns></returns>
        public List<E_Runners> GetRunners()
        {
            return this.Context.E_Runners.AsNoTracking().Where(x => x.EventID == this.ActiveEventID).OrderBy(o => o.Surname).ToList();
        }

        /// <summary>
        /// Get runner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public E_Runners GetRunner(int id, bool asNoTracking)
        {
            if(asNoTracking == false)
            {
                return this.Context.E_Runners.FirstOrDefault(x => x.RunnerID == id && x.EventID == this.ActiveEventID);
            }
            else
            {
                return this.Context.E_Runners.AsNoTracking().FirstOrDefault(x => x.RunnerID == id && x.EventID == this.ActiveEventID);
            }
        }

        /// <summary>
        /// Create update runner
        /// </summary>
        /// <param name="runnerID"></param>
        /// <param name="name"></param>
        /// <param name="categoryCode"></param>
        /// <param name="club"></param>
        /// <param name="startNumber"></param>
        /// <returns></returns>
        public string CreateUpdateRunner(int runnerID, string name, string categoryCode, string club, string startNumber)
        {
            // check if start number is already assigned
            if(!string.IsNullOrEmpty(startNumber))
            {
                if (this.Context.E_Runners.Count(x => x.EventID == this.ActiveEventID && x.StartNumber == startNumber && x.RunnerID != runnerID) > 0)
                {
                    return "Startovne cislo ma prideleny iny pretekar";
                }
            }

            // get runner
            var runner = this.GetRunner(runnerID, false);
            // create if not exist
            if (runner == null)
            {
                this.Context.E_Runners.Add(new E_Runners
                {
                    EventID = this.ActiveEventID.Value,
                    Surname = name,
                    StartNumber = startNumber,
                    CategoryID = categoryCode,
                });

                this.Context.SaveChanges();
            }
            else
            {
                runner.Surname = name;
                runner.StartNumber = startNumber;
                runner.CategoryID = categoryCode;

                this.Context.SaveChanges();
            }

            return string.Empty;
        }

        /// <summary>
        /// Delete runner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string DeleteRunner(int id)
        {
            var runner = this.GetRunner(id, false);
            // check if is used
            if(runner == null)
            {
                return "Pretekar nenajdeny!";
            }

            this.Context.E_Runners.Remove(runner);

            this.Context.SaveChanges();

            return string.Empty;
        }

    }
}
