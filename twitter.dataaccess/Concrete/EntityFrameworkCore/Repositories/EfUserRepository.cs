using Microsoft.EntityFrameworkCore;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Context;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {
        public async Task<List<User>> FollowerListAsync(long userId)
        {
            using var context = new TwitterContext();

            return await context.User.Where(User => User.Id == userId).Include(User => User.UserRelations).ToListAsync();
        }
    }
}