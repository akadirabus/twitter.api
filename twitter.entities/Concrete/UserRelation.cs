using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class UserRelation : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }

        public long FollowerId { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}