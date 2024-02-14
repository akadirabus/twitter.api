using Microsoft.EntityFrameworkCore;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Context;
using twitter.dataaccess.Interfaces;
using twitter.dto.Concrete.UserDtos;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {
        public async Task<List<User>> FollowerListAsync(long userId)
        {
            using var context = new TwitterContext();

            return await (from user in context.User
                            join userRelation in context.UserRelation on user.Id equals userRelation.UserId into joinedData
                            from userRelation in joinedData.DefaultIfEmpty()
                            where userRelation.FollowerId == userId
                          select new User()
                          {
                              Id = user.Id,
                              NameSurname = user.NameSurname,
                              UserName = user.UserName,
                          }).ToListAsync();

        }

        public async Task<List<User>> FollowingListAsync(long userId)
        {
            using var context = new TwitterContext();

            return await (from user in context.User
                          join userRelation in context.UserRelation on user.Id equals userRelation.UserId into joinedData
                          from userRelation in joinedData.DefaultIfEmpty()
                          where userRelation.UserId == userId
                          select new User()
                          {
                              Id = userRelation.FollowerId,
                              NameSurname = userRelation.User.NameSurname,
                              UserName = userRelation.User.UserName,
                          }).ToListAsync();

        }
    }
}