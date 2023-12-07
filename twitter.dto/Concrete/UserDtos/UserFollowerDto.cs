using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.UserDtos
{
    public class UserFollowerDto : IDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
    }
}