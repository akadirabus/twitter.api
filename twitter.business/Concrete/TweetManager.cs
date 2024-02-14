using twitter.business.Interfaces;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.business.Concrete
{
    public class TweetManager : GenericManager<Tweet>, ITweetService
    {
        private readonly IGenericDal<Tweet> _genericDal;
        private readonly ITweetDal _tweetDal;
        public TweetManager(IGenericDal<Tweet> genericDal, ITweetDal tweetDal) : base(genericDal)
        {
            _tweetDal = tweetDal;
            _genericDal = genericDal;
        }

        public async Task<Tweet> GetWithUserAsync(long tweetId)
        {
            return await _tweetDal.GetWithUserAsync(tweetId);
        }

        public async Task<List<Tweet>> ListOrderByDateTimeDescAsync(long? userId)
        {
            return await _tweetDal.ListOrderByDateTimeDescAsync(userId);
        }
    }
}
