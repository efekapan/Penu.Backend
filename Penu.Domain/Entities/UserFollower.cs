namespace Penu.Domain.Entities
{
    public class UserFollower
    {
        public Guid FollowerId { get; set; }
        public User Follower { get; set; } = default!;

        public Guid FollowingId { get; set; }
        public User Following { get; set; } = default!;
    }
}
