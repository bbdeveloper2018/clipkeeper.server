using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClipKeeper.Server.Data;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClipKeeper.Server.WebService.Controllers
{
    [Route("api/[controller]")]
    public class SceneController : Controller
    {
        private readonly ClipKeeperContext _context;
        private readonly IMapper _mapper;
        //private List<Scene> _scenes;

        public SceneController(ClipKeeperContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            //_scenes = new List<Scene>()
            //{
            //    new Scene()
            //    {
            //        id = 1,
            //        name = "SeanBaseball",
            //        filePreview = "https://localhost:44365/static/previews/SeanBaseball_preview.mp4",
            //        file = "https://localhost:44365/static/clips/SeanBaseball.mp4",
            //        stars = new List<Star> { new Star { starId = 4, name = "Sean Le" } },
            //        rating = 3,
            //        viewCount = 2,
            //        tags= new List<Tag>
            //        {
            //            new Tag { tagId = 1, value = "Family" },
            //            new Tag { tagId = 2, value = "Sports" },
            //            new Tag { tagId = 3, value = "Kids" }
            //        }
            //    },
            //    new Scene()
            //    {
            //        id = 2,
            //        name = "The.Tonight.Show.Starring.Jimmy.Fallon.2014.02.18.Jerry.Seinfeld.HDTV.x264-2HD",
            //        filePreview = "https://localhost:44365/static/previews/The.Tonight.Show.Starring.Jimmy.Fallon.2014.02.18.Jerry.Seinfeld.HDTV.x264-2HD_preview.mp4",
            //        file = "https://localhost:44365/static/clips/The.Tonight.Show.Starring.Jimmy.Fallon.2014.02.18.Jerry.Seinfeld.HDTV.x264-2HD.mp4",
            //        stars = new List<Star>
            //        {
            //            new Star { starId = 1, name = "Jimmy Fallon" },
            //            new Star { starId = 2, name = "Leslie Mann" },
            //            new Star { starId = 3, name = "Lady Gaga" },
            //            new Star { starId = 5, name = "Jamie Anderson" },
            //            new Star { starId = 6, name = "Kirsten Wiig" },
            //            new Star { starId = 7, name = "Jerry Seinfeld" },
            //        },
            //        rating = 2,
            //        viewCount = 0,
            //        tags= new List<Tag>
            //        {
            //            new Tag { tagId = 4, value = "TV Show" },
            //            new Tag { tagId = 5, value = "Music Performance" }
            //        }
            //    },
            //};
        }
        // GET: api/scene
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var videos = await _context.Videos
                .Include(v => v.Dvd)
                  .Include(v => v.PerformerVideos)
                    .ThenInclude(pv => pv.Performer)
                        .ThenInclude(p => p.PerformerImages)
                            .ThenInclude(pi => pi.Image)
                .Include(v => v.VideoTags)
                    .ThenInclude(vt => vt.Tag)
                .ToListAsync();

            var videoVms = _mapper.Map<IList<Video>, IList<VideoDto>>(videos);


            return Ok(videoVms);


            //return Ok(await _context.Videos
            //    .Include(v => v.PerformerVideos)
            //        .ThenInclude(pv => pv.Performer)
            //    .Include(v => v.VideoTags)
            //        .ThenInclude(vt => vt.Tag)
            //    .ToListAsync());
            //return Ok(_scenes);
        }

        // GET api/scene/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            return Ok(await _context.Videos
                .Include(v => v.PerformerVideos)
                    .ThenInclude(pv => pv.Performer)
                .Include(v => v.VideoTags)
                    .ThenInclude(vt => vt.Tag)
                .Where(x => x.VideoId == id).SingleOrDefaultAsync());
            //return Ok(_scenes.Where(x => x.id == id).SingleOrDefault());
        }

        //POST api/scene
        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Post(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count, size, filePath });
        }
    }

    public class Scene
    {
        public int id { get; set; }
        public string name { get; set; }
        public string file { get; set; }
        public string filePreview { get; set; }
        public List<Star> stars { get; set; }
        public int viewCount { get; set; }
        public int rating { get; set; }
        public List<Tag> tags { get; set; }
    }

    public class Tag
    {
        public int tagId { get; set; }
        public string value { get; set; }
    }

    public class Star
    {
        public int starId { get; set; }
        public string name { get; set; }
    }



}


