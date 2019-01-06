using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class WebsiteProfile: Profile
    {
        public WebsiteProfile()
        {
            CreateMap<Website, WebsiteDto>();
        }
    }
}
