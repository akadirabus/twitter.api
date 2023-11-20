using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class MessageType : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int MessageId { get; set; }
        public Message? Message { get; set; }
    }
}