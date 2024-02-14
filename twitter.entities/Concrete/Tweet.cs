using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Tweet : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Content { get; set; }

        public List<TweetHashtag>? TweetHashtags { get; set; }
        public List<TweetUser>? TweetUsers { get; set; }

        public User? User { get; set; }
        public long? UserId { get; set; }

        public DefTweetType? DefTweetType { get; set; }
        public short? DefTweetTypeId { get; set; }
    }
}