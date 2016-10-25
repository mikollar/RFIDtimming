using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class R_TagReadMap : EntityTypeConfiguration<R_TagRead>
    {
        public R_TagReadMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ReadID, t.EventID });

            this.Property(t => t.ReadID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Properties
            this.Property(t => t.TagID)
                .IsRequired()
                .HasMaxLength(100)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserData)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("R_TagRead");
            this.Property(t => t.ReadID).HasColumnName("ReadID");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.TagID).HasColumnName("TagID");
            this.Property(t => t.UserData).HasColumnName("UserData");
            this.Property(t => t.ReadTime).HasColumnName("ReadTime");
        }
    }
}
