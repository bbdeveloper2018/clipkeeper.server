using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public List<VideoTag> VideoTags { get; set; }
    }
}
