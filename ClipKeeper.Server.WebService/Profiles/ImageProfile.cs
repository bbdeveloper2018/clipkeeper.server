using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class ImageProfile: Profile
    {
        public ImageProfile()
        {
            CreateMap<Image, ImageDto>();
        }
    }
}
