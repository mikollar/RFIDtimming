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

    class CategoriesHandler : BaseHandler
    {
        public CategoriesHandler(E_Events ev) : base(ev != null ? (int?)ev.EventID : null)
        {
        }

        public CategoriesHandler(E_Events ev, Context context)
            : base(ev != null ? (int?)ev.EventID : null, context)
        {
        }

        /// <summary>
        /// Get all categories
        /// </summary>
        /// <returns></returns>
        public List<E_Category> GetCategories()
        {
            return this.Context.E_Category.AsNoTracking().Where(x => x.EventID == this.ActiveEventID).OrderBy(o => o.CategoryName).ToList();
        }

        /// <summary>
        /// Get category
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public E_Category GetCategory(string code)
        {
            return this.Context.E_Category.FirstOrDefault(x => x.CategoryID == code && x.EventID == this.ActiveEventID);
        }

        /// <summary>
        /// Create pdate category
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="laps"></param>
        /// <param name="minLapTime"></param>
        /// <param name="startTimeOffset"></param>
        /// <returns></returns>
        public bool CreateUpdateCategory(string code, string name, int laps, int minLapTime, int startTimeOffset)
        {
            // get category
           var category = this.GetCategory(code);
            // create if not exist
           if (category == null)
           {
               this.Context.E_Category.Add(new E_Category
               {
                   CategoryID = code,
                   CategoryName = name,
                   EventID = this.ActiveEventID.Value,
                   Laps = laps,
                   MinLapTime = minLapTime,
                   OffsetStartTime = startTimeOffset
               });

               this.Context.SaveChanges();
           }
           else
           {
                   category.CategoryName = name;
                   category.Laps = laps;
                   category.MinLapTime = minLapTime;
                   category.OffsetStartTime = startTimeOffset;

                   this.Context.SaveChanges();
           }

           return true;
        }

        /// <summary>
        /// Delete category
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string DeleteCategory(string code)
        {
            var category = this.GetCategory(code);
            // check if is used
            if(this.Context.E_Runners.Count(x => x.EventID == this.ActiveEventID && x.CategoryID == code) > 0)
            {
                return "Kategoria je priradena pretekarom!";
            }

            this.Context.E_Category.Remove(category);

            this.Context.SaveChanges();

            return string.Empty;
        }

    }
}
