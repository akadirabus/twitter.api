using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Context;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfHashtagRepository : EfGenericRepository<Hashtag>, IHashtagDal
    {
        public async Task<List<Hashtag>> ListTrendTopic(int hashtagCount = 10)
        {
            var context = new TwitterContext();

            return await context.Hashtag.Include(I => I.TweetHashtags).OrderByDescending(I => I.TweetCount).Take(hashtagCount).ToListAsync();
        }
    }
}