using twitter.business.Interfaces;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.business.Concrete
{
    public class HashtagManager : GenericManager<Hashtag>, IHashtagService
    {
        private readonly IGenericDal<Hashtag> _genericDal;
        private readonly IHashtagDal _hashtagDal;
        public HashtagManager(IGenericDal<Hashtag> genericDal, IHashtagDal hashtagDal) : base(genericDal)
        {
            _hashtagDal = hashtagDal;
            _genericDal = genericDal;
        }

        public async Task<List<Hashtag>> ListTrendTopic()
        {
            return await _hashtagDal.ListTrendTopic();
        }
    }
}