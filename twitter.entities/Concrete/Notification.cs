using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Notification : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Content { get; set; }

        public long? UserId { get; set; }
        public User? User { get; set; }
    }
}