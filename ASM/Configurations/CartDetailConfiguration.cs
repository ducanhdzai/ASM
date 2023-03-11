using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Quantity).HasColumnType("int").HasColumnName("Quantity").IsRequired();
            builder.HasOne(c => c.Cart).WithMany(c => c.CardDetails).HasForeignKey(c => c.UserID);
            builder.HasOne(c => c.Product).WithMany(c => c.CartDetails).HasForeignKey(c => c.IDSP);
        }
    }
}
