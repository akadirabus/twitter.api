using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TweetType : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public long TweetId { get; set; }
        public Tweet? Tweet { get; set; }
    }
}