using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class User : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string PersonelInformation { get; set; }
        public string Location { get; set; }
        public DateTime BirthDate { get; set; }

        public List<UserRelation>? UserRelations { get; set; }
        public List<Tweet>? Tweets { get; set; }
        public List<Message>? Messages { get; set; }
        public List<Notification>? Notifications { get; set; }
        public List<TweetUser>? TweetUsers { get; set; }
    }
}