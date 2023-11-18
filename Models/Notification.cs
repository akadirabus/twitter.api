namespace twitter_api.Models
{
    public class Notification
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Content { get; set; }
        public long refUser { get; set; }
    }
}