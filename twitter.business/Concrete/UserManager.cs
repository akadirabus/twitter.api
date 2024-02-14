using twitter.business.Interfaces;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IGenericDal<User> _genericDal;
        private readonly IUserDal _userDal;
        public UserManager(IGenericDal<User> genericDal, IUserDal userDal) : base(genericDal)
        {
            _userDal = userDal;
            _genericDal = genericDal;
        }

        public async Task<List<User>> FollowerListAsync(long userId)
        {
            return await _userDal.FollowerListAsync(userId);
        }

        public async Task<List<User>> FollowingListAsync(long userId)
        {
            return await _userDal.FollowingListAsync(userId);
        }
    }
}