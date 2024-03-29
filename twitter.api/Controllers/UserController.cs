﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using twitter.business.Interfaces;
using twitter.dto.Concrete.UserDtos;
using twitter.entities.Concrete;

namespace twitter.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UserDto>> List()
        {
            return _mapper.Map<List<UserDto>>(await _userService.ListAsync());
        }

        [HttpGet]
        public async Task<UserDto> Get(long userId)
        {
            return _mapper.Map<UserDto>(await _userService.GetAsync(I => I.Id == userId));
        }

        [HttpGet]
        public async Task<List<UserFollowerDto>> FollowerList(long userId)
        {
            var x = await _userService.FollowerListAsync(userId);
            return _mapper.Map<List<UserFollowerDto>>(x);
        }

        [HttpGet]
        public async Task<List<UserFollowingDto>> FollowingList(long userId)
        {
            var x = await _userService.FollowingListAsync(userId);
            return _mapper.Map<List<UserFollowingDto>>(x);
        }


        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            await _userService.UpdateAsync(_mapper.Map<User>(userUpdateDto));
            return Ok(userUpdateDto);
        }
    }
}