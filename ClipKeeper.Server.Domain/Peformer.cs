using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Performer
    {
        public int PerformerId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int Rating { get; set; }
        public string Gender { get; set; }
        public List<PerformerVideo> PerformerVideos { get; set; }
        public List<PerformerImage> PerformerImages { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }

    }
}
