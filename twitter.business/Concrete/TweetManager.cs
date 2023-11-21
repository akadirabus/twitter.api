using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
