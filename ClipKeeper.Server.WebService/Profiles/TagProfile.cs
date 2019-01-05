using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class TagProfile: Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagDto>();
        }
    }
}
