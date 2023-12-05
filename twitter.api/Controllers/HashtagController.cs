using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using twitter.business.Interfaces;
using twitter.dto.Concrete.HashtagDtos;

namespace twitter.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HashtagController : ControllerBase
    {
        private readonly IHashtagService _hashtagService;
        private readonly IMapper _mapper;
        public HashtagController(IHashtagService hashtagService, IMapper mapper)
        {
            _hashtagService = hashtagService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<HashtagListDto>> List()
        {
            return _mapper.Map<List<HashtagListDto>>(await _hashtagService.ListAsync());
        }
    }
}