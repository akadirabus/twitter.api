using AutoMapper;
using twitter.dto.Concrete.HashtagDtos;
using twitter.dto.Concrete.TweetDtos;
using twitter.dto.Concrete.UserDtos;
using twitter.entities.Concrete;

namespace twitter.api.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<TweetAddDto, Tweet>();
            CreateMap<Tweet, TweetAddDto>();

            CreateMap<TweetListDto, Tweet>();
            CreateMap<Tweet, TweetListDto>();

            CreateMap<HashtagListDto, Hashtag>();
            CreateMap<Hashtag, HashtagListDto>();

            CreateMap<HashtagListTrendTopicDto, Hashtag>();
            CreateMap<Hashtag, HashtagListTrendTopicDto>();

            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<UserUpdateDto, User>();
            CreateMap<User, UserUpdateDto>();

            CreateMap<UserFollowerDto, User>();
            CreateMap<User, UserFollowerDto>();

            CreateMap<UserFollowingDto, User>();
            CreateMap<User, UserFollowingDto>();

            CreateMap<TweetListUserDto, User>();
            CreateMap<User, TweetListUserDto>();
        }
    }
}