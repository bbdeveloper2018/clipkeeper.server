using System;
using System.Collections.Generic;
using System.Text;

namespace ClipKeeper.Server.Domain
{
    public class PerformerImage
    {
        public int PerformerId { get; set; }
        public Performer Performer { get; set; }
        public int ImageId { get; set; }
        public Image  Image { get; set; }
    }
}
