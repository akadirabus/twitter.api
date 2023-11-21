using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private readonly IGenericDal<Tweet> _genericDal;
        private readonly ITweetDal _tweetDal;
        public TweetController(IGenericDal<Tweet> genericDal, ITweetDal tweetDal)
        {
            _genericDal = genericDal; 
            _tweetDal = tweetDal;
        }

        [HttpGet]
        public async Task<List<Tweet>> List()
        {
            return await _genericDal.GetAllAsync();
        }
    }
}
