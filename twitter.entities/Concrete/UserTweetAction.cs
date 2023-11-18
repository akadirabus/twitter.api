using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class UserTweetAction : ITable
    {
        public long Id { get; set; }
        public long refUser { get; set; }
        public long refTweet { get; set; }
        public int refAction { get; set; }
    }
}