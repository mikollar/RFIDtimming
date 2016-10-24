using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class E_RunnersMap : EntityTypeConfiguration<E_Runners>
    {
        public E_RunnersMap()
        {
            // Primary Key
            this.HasKey(t => t.RunnerID);

            // Properties
            this.Property(t => t.Firstname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.Surname)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.StartNumber)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CategoryID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("E_Runners");
            this.Property(t => t.RunnerID).HasColumnName("RunnerID");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.Firstname).HasColumnName("Firstname");
            this.Property(t => t.Surname).HasColumnName("Surname");
        }
    }
}
