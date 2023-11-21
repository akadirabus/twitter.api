using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Tweet : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Content { get; set; }
        public int TweetType { get; set; }

        public List<TweetHashtag>? TweetHashtags { get; set; }
        public List<UserTweet>? UserTweets { get; set; }
        public long? UserId { get; set; }
        public User? User { get; set; }
    }
}