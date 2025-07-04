using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class UserSettings : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

        public bool EmailNotificationsEnabled { get; set; } = true;
        public bool IsProfilePrivate { get; set; } = false;


    }
}
