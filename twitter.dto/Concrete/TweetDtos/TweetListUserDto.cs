using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.TweetDtos
{
    public class TweetListUserDto : IDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
    }
}