using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class DefActionType : ITable
    {
        public short Id { get; set; }
        public string Name { get; set; }

        public List<TweetUser> TweetUsers { get; set; }
    }
}