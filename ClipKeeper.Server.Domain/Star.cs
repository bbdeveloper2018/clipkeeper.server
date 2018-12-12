using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Star
    {
        public int StarId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime EntryDate { get; set; }
        public List<StarVideo> StarVideos { get; set; }

    }
}
