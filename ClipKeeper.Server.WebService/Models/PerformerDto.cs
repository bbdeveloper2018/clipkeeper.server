using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Models
{
    public class PerformerDto
    {
        public int PerformerId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int Rating { get; set; }
        public string Gender { get; set; }
        public List<ImageDto> Images { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }
    }
}
