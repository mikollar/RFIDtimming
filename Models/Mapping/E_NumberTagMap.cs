using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RFIDTimming.Models.Mapping
{
    public class E_NumberTagMap : EntityTypeConfiguration<E_NumberTag>
    {
        public E_NumberTagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BibNumber, t.ValidFrom });

            // Properties
            this.Property(t => t.BibNumber)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.TagID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("E_NumberTag");
            this.Property(t => t.BibNumber).HasColumnName("BibNumber");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.TagID).HasColumnName("TagID");
        }
    }
}