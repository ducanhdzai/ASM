using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(c => c.UserID);
            builder.Property(c => c.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.PassWord).HasColumnName("PassWord").HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(c => c.Status).HasColumnType("int").HasColumnName("Status");
            builder.HasOne<Role>(c => c.Role).WithMany(c => c.Users).HasForeignKey(c => c.RoleID);
        }
    }
}
