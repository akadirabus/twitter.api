namespace twitter.entities.Concrete
{
    public class Notification
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string? Content { get; set; }
        public long refUser { get; set; }
    }
}