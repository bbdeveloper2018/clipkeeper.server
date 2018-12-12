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
        public DateTime EntryDate { get; set; }        
        public List<StarVideo> StarVideos { get; set; }
    }
}
