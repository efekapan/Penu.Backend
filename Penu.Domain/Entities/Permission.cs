using Penu.Domain.Common;

namespace Penu.Domain.Entities
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string Description { get; set; } = default!;

        public ICollection<Role> Roles { get; set; } = new List<Role>();

    }
}
