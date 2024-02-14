using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TweetUser : ITable
    {
        public long Id { get; set; }

        public long TweetId { get; set; }
        public Tweet Tweet { get; set; }
        
        public long UserId { get; set; }
        public User User { get; set; }


        public DefActionType? DefActionType { get; set; }
        public short? DefActionTypeId { get; set; }
    }
}