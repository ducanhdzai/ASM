using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.Price).HasColumnName("Price").IsRequired();
            builder.Property(c => c.AvailableQuantity).HasColumnType("int").HasColumnName("AvailableQuantity").IsRequired();
            builder.Property(c => c.Status).HasColumnType("int").HasColumnName("Quantity").IsRequired();
            builder.Property(c => c.Supplier).HasColumnName("Supplier").HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(200).IsUnicode().IsRequired();
        }
    }
}
