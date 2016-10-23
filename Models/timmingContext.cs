using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RFIDTimming.Models.Mapping;

namespace RFIDTimming.Models
{
    public partial class timmingContext : DbContext
    {
        static timmingContext()
        {
            Database.SetInitializer<timmingContext>(null);
        }

        public timmingContext()
            : base("Name=timmingContext")
        {
        }

        public DbSet<E_Events> E_Events { get; set; }
        public DbSet<E_NumberTag> E_NumberTag { get; set; }
        public DbSet<E_Runners> E_Runners { get; set; }
        public DbSet<R_TagRead> R_TagRead { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new E_EventsMap());
            modelBuilder.Configurations.Add(new E_NumberTagMap());
            modelBuilder.Configurations.Add(new E_RunnersMap());
            modelBuilder.Configurations.Add(new R_TagReadMap());
        }
    }
}
