using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class DefTweetType : ITable
    {
        public short Id { get; set; }
        public string Name { get; set; }
    }
}
