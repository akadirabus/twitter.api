using twitter.entities.Concrete;

namespace twitter.business.Interfaces
{
    public interface IHashtagService : IGenericService<Hashtag>
    {
        Task<List<Hashtag>> ListTrendTopic();
    }
}