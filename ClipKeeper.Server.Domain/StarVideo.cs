using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class StarVideo
    {
        public int StarId { get; set; }
        public Star Star { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
