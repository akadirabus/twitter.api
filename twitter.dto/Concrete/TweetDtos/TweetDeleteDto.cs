using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.TweetDtos
{
    public class TweetDeleteDto : IDto
    {
        public long Id { get; set; }
    }
}