using AutoMapper;
using twitter.dto.Concrete.TweetDtos;
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
        }
    }
}