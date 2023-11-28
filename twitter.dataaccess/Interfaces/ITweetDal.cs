using twitter.entities.Concrete;

namespace twitter.dataaccess.Interfaces
{
    public interface ITweetDal : IGenericDal<Tweet>
    {
        Task<List<Tweet>> ListOrderByDateTimeDescAsync(long userId);
    }
}