using twitter.entities.Concrete;

namespace twitter.dataaccess.Interfaces
{
    public interface IHashtagDal : IGenericDal<Hashtag>
    {
        Task<List<Hashtag>> ListTrendTopic(int hashtagCount);
    }
}