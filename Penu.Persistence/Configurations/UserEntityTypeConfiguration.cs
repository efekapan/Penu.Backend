using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Penu.Domain.Entities;

namespace Penu.Persistence.Configurations
{
    public class UserEntityTypeConfiguration : BaseEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(u => u.Username).IsRequired().HasMaxLength(100);
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Surname).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);

            builder.HasOne(u => u.UserDetails).WithOne(ud => ud.User).HasForeignKey<UserDetails>(ud => ud.UserId);
            builder.HasOne(u => u.UserSettings).WithOne(us => us.User).HasForeignKey<UserSettings>(us => us.UserId);
            builder.HasMany(u => u.RefreshTokens).WithOne(rt => rt.User).HasForeignKey(rt => rt.UserId);
        }
    }
}
