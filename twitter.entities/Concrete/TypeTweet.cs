using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TypeTweet : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}