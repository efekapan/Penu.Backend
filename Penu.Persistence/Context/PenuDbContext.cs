using Microsoft.EntityFrameworkCore;
using Penu.Domain.Entities;
using System.Reflection;

namespace Penu.Persistence.Context
{
    public class PenuDbContext : DbContext
    {
        public PenuDbContext(DbContextOptions options) : base(options)
        {
        }

        protected PenuDbContext()
        {
        }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<UserFollower> UserFollower { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
