using twitter.entities.Concrete;

namespace twitter.dataaccess.Interfaces
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<List<User>> FollowerListAsync(long userId);
    }
}