using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Tweet : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
        public int refTweet{ get; set; }
        public string? Content { get; set; }
    }
}