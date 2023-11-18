namespace twitter.entities.Concrete
{
    public class Tweet
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
        public int refTweetStatus { get; set; }
        public string? Content { get; set; }
    }
}