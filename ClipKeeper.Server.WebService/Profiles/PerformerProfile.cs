using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class PerformerProfile: Profile
    {
        public PerformerProfile()
        {
            CreateMap<Performer, PerformerDto>()
                .ForMember(
                    dest => dest.Images,
                    opt => opt.MapFrom(src => 
                                        src.PerformerImages
                                            .Select(x => x.Image)
                                            .ToList()));
        }
    }
}
