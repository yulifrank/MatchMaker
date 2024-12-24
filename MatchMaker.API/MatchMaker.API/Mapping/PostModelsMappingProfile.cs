using AutoMapper;
using MatchMaker.API.Models;
using MatchMaker.Core.Entities;
using MatchMaker.Core.Entities.MatchMaker.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MatchMaker.API.Mapping
{
    public class PostModelsMappingProfile : Profile
    {
        public PostModelsMappingProfile()
        {
            CreateMap<PersonPostModel, Person>().ReverseMap();
            CreateMap<IdeaPostModel, Idea>().ReverseMap();
            CreateMap<GuyPostModel, Guy>();
            CreateMap<GirlPostModel, Girl>();

        }
    }
}
