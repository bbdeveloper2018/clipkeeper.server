using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Video
    {
        public int VideoId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string PreviewPath { get; set; }
        public string PosterImagePath { get; set; }
        public int Rating { get; set; }
        public Dvd Dvd { get; set; }
        public Website Website { get; set; }
        public List<PerformerVideo> PerformerVideos { get; set; }
        public List<VideoTag> VideoTags { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }
    }
}
