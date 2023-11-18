using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Hashtag : ITable
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime RecordTime { get; set; }
        public List<TweetHashtag>? TweetHashtags { get; set; }
    }
}
