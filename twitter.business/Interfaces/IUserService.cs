using twitter.entities.Concrete;

namespace twitter.business.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<List<User>> FollowerListAsync(long userId);
    }
}