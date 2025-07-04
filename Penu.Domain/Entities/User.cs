using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;

        public UserDetails UserDetails { get; set; } = default!;
        public UserSettings UserSettings { get; set; } = default!;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        public ICollection<UserFollower> Followers { get; set; } = new List<UserFollower>();
        public ICollection<UserFollower> Following { get; set; } = new List<UserFollower>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();


    }
}
