using MoviesApp.Models;
using AutoMapper;

namespace MoviesApp.ViewModels.AutoMapperProfiles
{
    public class ActorProfile: Profile
    {
        public ActorProfile()
        {
            CreateMap<Actor, InputActorsViewModel>().ReverseMap();
            CreateMap<Actor, DeleteActorsViewModel>();
            CreateMap<Actor, EditActorsViewModel>().ReverseMap();
            CreateMap<Actor, ActorsViewModel>();
        }
    }
}