using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TypeAction : ITable
    {
        public long Id { get; set; }
        public string? Name { get; set; }
    }
}