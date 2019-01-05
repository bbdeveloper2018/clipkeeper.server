using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Models
{
    public class VideoDto
    {
        public int VideoId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string PreviewPath { get; set; }
        public string PosterImagePath { get; set; }
        public int Rating { get; set; }
        public DvdDto Dvd { get; set; }
        public List<PerformerDto> Performers { get; set; }
        public List<TagDto> Tags { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }
    }
}
