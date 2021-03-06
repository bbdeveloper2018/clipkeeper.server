﻿using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class DvdProfile: Profile
    {
        public DvdProfile()
        {
            CreateMap<Dvd, DvdDto>()
                .ForMember(
                    dest => dest.StudioName,
                    opt => opt.MapFrom(src => src.Studio.Name));
        }
    }
}
