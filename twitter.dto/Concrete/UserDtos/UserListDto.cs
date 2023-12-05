using twitter.dto.Interfaces;

namespace twitter.dto.Concrete.UserDtos
{
    public class UserListDto : IDto
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string PersonelInformation { get; set; }
        public string Location { get; set; }
        public DateTime BirthDate { get; set; }
    }
}