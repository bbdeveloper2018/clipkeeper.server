using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class StudioProfile: Profile
    {
        public StudioProfile()
        {
            CreateMap<Studio, StudioDto>();
        }
    }
}
