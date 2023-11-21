using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class UserTweet : ITable
    {
        public long Id { get; set; }
        public int Type { get; set; }
        public long TweetId { get; set; }
        public Tweet Tweet { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}