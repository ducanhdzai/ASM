using ASM.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(c => c.ID);
            builder.Property(c => c.RoleName).HasColumnName("RoleName").HasColumnType("nvarchar").HasMaxLength(30).IsUnicode().IsRequired();
            builder.Property(c => c.Description).HasColumnName("Description").HasColumnType("nvarchar").HasMaxLength(200).IsUnicode().IsRequired();
            builder.Property(c => c.Status).HasColumnType("int").HasColumnName("Status");
        }
    }
}
