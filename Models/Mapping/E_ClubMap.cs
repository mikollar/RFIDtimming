using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class E_ClubMap : EntityTypeConfiguration<E_Club>
    {
        public E_ClubMap()
        {
            // Primary Key
            this.HasKey(t => t.ClubID);

            // Properties
            this.Property(t => t.ClubID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("E_Club");
        }
    }
}
