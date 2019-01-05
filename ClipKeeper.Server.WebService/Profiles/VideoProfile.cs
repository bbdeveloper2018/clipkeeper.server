using AutoMapper;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Profiles
{
    public class VideoProfile: Profile
    {
        public VideoProfile()
        {
            //Mapper.Initialize(m => {
            //    m.CreateMap<Video, VideoDto>()
            //        .Include<Tag, TagDto>();
            //    m.CreateMap<Tag, TagDto>();
            //});

            CreateMap<Video, VideoDto>()
                .ForMember(
                    dest => dest.Dvd,
                    opt => opt.MapFrom(src => src.Dvd))
                .ForMember(
                    dest => dest.Performers,
                    opt => opt.MapFrom(src =>
                                            src.PerformerVideos
                                                .Select(x => x.Performer)
                                                .ToList()))
                .ForMember(
                    dest => dest.Tags,
                    opt => opt.MapFrom(src =>
                                            src.VideoTags
                                                .Select(x => x.Tag)
                                                .ToList()));
        }
    }
}
