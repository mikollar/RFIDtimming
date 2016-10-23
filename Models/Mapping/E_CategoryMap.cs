using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class E_CategoryMap : EntityTypeConfiguration<E_Category>
    {
        public E_CategoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CategoryID, t.EventID });

            // Properties
            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("E_Category");
            this.Property(t => t.EventID).HasColumnName("EventID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
        }
    }
}
