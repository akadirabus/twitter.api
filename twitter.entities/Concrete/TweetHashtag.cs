using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TweetHashtag : ITable
    {
        public long Id { get; set; }

        public long TweetId { get; set; }
        public Tweet? Tweet { get; set; }
        public long HasttagId { get; set; }
        public Hashtag? Hashtag { get; set; }
    }
}