using System;

namespace ClipKeeper.Server.WebService.Models
{
    public class StudioDto
    {
        public int StudioId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateStamp { get; set; }
    }
}
