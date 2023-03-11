using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.CreateDate).HasColumnType("datetime").HasColumnName("CreateDate");
            builder.Property(c => c.Status).HasColumnType("int").HasColumnName("Status").IsRequired();
            builder.HasOne(c => c.User).WithMany(c => c.Bills).HasForeignKey(c => c.UserID).HasConstraintName("FK_USERBILL").IsRequired();
        }
    }
}
