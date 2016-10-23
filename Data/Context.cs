using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RFIDTimming.Models;
using RFIDTimming.Models.Mapping;

namespace RFIDTimming.Data
{
 
        /// <summary>
        /// </summary>
        public class Context : DbContext
        {


            #region Construction
            // Used by EF migrations
            public Context()
                : base("Context")
            {
                this.Configuration.LazyLoadingEnabled = false;
                this.Configuration.ProxyCreationEnabled = true;
            //  Database.SetInitializer<Context>(null);

            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }



        #endregion
        #region DataSet Properties

        // public DbSet<l_rtftext> l_rtftext { get; set; }
        public DbSet<E_Events> E_Events { get; set; }
        public DbSet<E_NumberTag> E_NumberTag { get; set; }
        public DbSet<E_Runners> E_Runners { get; set; }
        public DbSet<R_TagRead> R_TagRead { get; set; }
        public DbSet<E_Category> E_Category { get; set; }
        #endregion

        #region Overrides

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("dbo");


            // builder.Configurations.Add(new l_rtftextMap());
            modelBuilder.Configurations.Add(new E_EventsMap());
            modelBuilder.Configurations.Add(new E_NumberTagMap());
            modelBuilder.Configurations.Add(new E_RunnersMap());
            modelBuilder.Configurations.Add(new R_TagReadMap());
            modelBuilder.Configurations.Add(new E_CategoryMap());

            base.OnModelCreating(modelBuilder);
        }

        #endregion

        public virtual void Commit()
            {
                base.SaveChanges();
            }
        }

}
