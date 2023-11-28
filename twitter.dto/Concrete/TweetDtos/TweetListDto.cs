using twitter.dto.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dto.Concrete.TweetDtos
{
    public class TweetListDto : IDto
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string Content { get; set; }
        public int TweetType { get; set; }
        public User User { get; set; }
    }
}