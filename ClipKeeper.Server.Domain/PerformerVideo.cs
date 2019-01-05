using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class PerformerVideo
    {
        public int PerformerId { get; set; }
        public Performer Performer { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
