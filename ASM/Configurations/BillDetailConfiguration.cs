using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Quantity).HasColumnType("int").HasColumnName("Quantity").IsRequired();
            builder.Property(c => c.Price).HasColumnName("Price").IsRequired();
            builder.HasOne(c => c.Bill).WithMany(c => c.BillDetails).IsRequired().HasForeignKey(c => c.IDHD);
            builder.HasOne(c => c.Product).WithMany(c => c.BillDetails).IsRequired().HasForeignKey(c => c.IDSP);
        }
    }
}
