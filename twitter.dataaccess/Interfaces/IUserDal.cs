using twitter.dto.Concrete.UserDtos;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Interfaces
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<List<User>> FollowerListAsync(long userId);
        Task<List<User>> FollowingListAsync(long userId);
    }
}