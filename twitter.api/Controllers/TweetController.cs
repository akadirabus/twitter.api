using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using twitter.business.Interfaces;
using twitter.dto.Concrete.TweetDtos;
using twitter.entities.Concrete;

namespace twitter.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TweetController : ControllerBase
    {
        private readonly ITweetService _tweetService;
        private readonly IMapper _mapper;
        public TweetController(ITweetService tweetService, IMapper mapper)
        {
            _tweetService = tweetService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<TweetListDto>> ListOrderByDateTimeDesc(long userId)
        {
            return _mapper.Map<List<TweetListDto>>(await _tweetService.ListOrderByDateTimeDescAsync(userId));
        }

        [HttpPost]
        public async Task<IActionResult> Add(TweetAddDto tweetAddDto)
        {
            await _tweetService.AddAsync(_mapper.Map<Tweet>(tweetAddDto));
            return Created("", tweetAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(TweetDeleteDto tweetDeleteDto)
        {
            await _tweetService.RemoveAsync(_mapper.Map<Tweet>(tweetDeleteDto));
            return NoContent();
        }
    }
}