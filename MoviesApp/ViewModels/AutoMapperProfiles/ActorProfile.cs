using MoviesApp.Models;
using AutoMapper;
using MoviesApp.Services.Dto;

namespace MoviesApp.ViewModels.AutoMapperProfiles
{
    public class ActorProfile: Profile
    {
        public ActorProfile()
        {
            CreateMap<ActorDto, InputActorsViewModel>().ReverseMap();
            CreateMap<ActorDto, DeleteActorsViewModel>();
            CreateMap<ActorDto, EditActorsViewModel>().ReverseMap();
            CreateMap<ActorDto, ActorsViewModel>();
        }
    }
}