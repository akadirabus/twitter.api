using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class ActionType : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long UserTweetActionId { get; set; }
        public UserTweetAction? UserTweetAction { get; set; }
    }
}