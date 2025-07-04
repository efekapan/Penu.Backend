using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}
