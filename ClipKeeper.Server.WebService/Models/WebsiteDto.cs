using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClipKeeper.Server.WebService.Models
{
    public class WebsiteDto
    {
        public int WebsiteId { get; set; }
        public string Name { get; set; }
        public string SiteUrl { get; set; }
    }
}
