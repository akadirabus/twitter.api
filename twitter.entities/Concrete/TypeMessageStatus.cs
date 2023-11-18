using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class TypeMessageStatus : ITable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}