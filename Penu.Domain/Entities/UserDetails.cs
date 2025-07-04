using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class UserDetails : BaseEntity
    {
        public string ProfilePictureUrl { get; set; } = default!;
        public string BannerUrl { get; set; } = default!;
        public string Bio { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? Location { get; set; }
        public bool IsVerified { get; set; } = false;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

    }
}
