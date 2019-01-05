using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Dvd
    {
        public int DvdId { get; set; }
        public string Title { get; set; }
        public Studio Studio { get; set; }
        public string Notes { get; set; }
        public int ReleaseYear { get; set; }
        public string FrontCoverPath { get; set; }
        public string BackCoverPath { get; set; }
        public int Rating { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }        
    }
}
