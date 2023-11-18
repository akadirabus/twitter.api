using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TweetHashtag : ITable
    {
        public long Id { get; set; }
        public long refTweet { get; set; }
        public long refHashtag { get; set; }
    }
}