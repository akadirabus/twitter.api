using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.TweetDtos
{
    public class TweetAddDto : IDto
    {
        public string Content { get; set; }
        public int TweetType { get; set; }
    }
}