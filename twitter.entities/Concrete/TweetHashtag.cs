namespace twitter.entities.Concrete
{
    public class TweetHashtag
    {
        public long Id { get; set; }
        public long refTweet { get; set; }
        public long refHashtag { get; set; }
    }
}