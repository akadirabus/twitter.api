using twitter.entities.Concrete;

namespace twitter.business.Interfaces
{
    public interface ITweetService : IGenericService<Tweet>
    {
        Task<List<Tweet>> ListOrderByDateTimeDescAsync(long userId);
    }
}
