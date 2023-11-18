namespace twitter_api.Models
{
    public class Message
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
        public string? Content { get; set; }
        public int refMessageStatus { get; set; }
    }
}