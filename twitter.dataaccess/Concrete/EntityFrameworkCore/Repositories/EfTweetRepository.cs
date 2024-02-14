using Microsoft.EntityFrameworkCore;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Context;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfTweetRepository : EfGenericRepository<Tweet>, ITweetDal
    {
        public async Task<List<Tweet>> ListOrderByDateTimeDescAsync(long userId)
        {
            using var context = new TwitterContext();

            return await context.Tweet.Join(context.User, tweet => tweet.UserId, user => user.Id, (tweet, tweetUser) => new
            {
                tweet,
                tweetUser.NameSurname,
                tweetUser.UserName
            }).Where(I => I.tweet.UserId == userId).Select(I => new Tweet
            {
                RecordTime = I.tweet.RecordTime,
                Content = I.tweet.Content,
                Id = I.tweet.Id,
                TweetType = I.tweet.TweetType,
                User = new User {
                    Id = I.tweet.User.Id
                }
            })
            .OrderByDescending(I => I.RecordTime)
            .ToListAsync();
        }
    }
}