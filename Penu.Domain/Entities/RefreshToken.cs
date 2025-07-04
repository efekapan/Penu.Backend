using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; } = default!;
        public DateTime Expiry { get; set; }
        public bool IsRevoked { get; set; } = false;

        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

    }
}
