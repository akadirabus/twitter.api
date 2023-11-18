namespace twitter_api.Models
{
    public class UserTweetAction
    {
        public long Id { get; set; }
        public long refUser { get; set; }
        public long refTweet { get; set; }
        public int refAction { get; set; }
    }
}