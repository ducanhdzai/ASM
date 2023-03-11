using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.UserID);
            builder.HasOne(c => c.User).WithOne(c => c.Cart);
            builder.Property(c => c.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(200).IsUnicode().IsRequired();
        }
    }
}
