using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class E_EventsMap : EntityTypeConfiguration<E_Events>
    {
        public E_EventsMap()
        {
            // Primary Key
            this.HasKey(t => t.EventID);

            // Properties
            this.Property(t => t.EventName)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("E_Events");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.EventName).HasColumnName("EventName");
            this.Property(t => t.EventDateTime).HasColumnName("EventDateTime");
        }
    }
}
