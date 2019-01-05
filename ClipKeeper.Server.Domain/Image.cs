using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public bool IsPrimary { get; set; }
        public List<PerformerImage> PerformerImages { get; set; }
    }
}
