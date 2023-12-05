using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.HashtagDtos
{
    public class HashtagListDto : IDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}