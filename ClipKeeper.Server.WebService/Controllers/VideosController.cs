using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClipKeeper.Server.Data;
using ClipKeeper.Server.Domain;
using ClipKeeper.Server.WebService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClipKeeper.Server.WebService.Controllers
{
    /// <summary>
    /// Video API
    /// </summary>
    [Route("api/[controller]")]
    public class VideosController : Controller
    {
        private readonly ClipKeeperContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// Initializes the database context and Automapper.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public VideosController(ClipKeeperContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/videos
        /// <summary>
        /// Retrieves a list of all videos.
        /// </summary>
        /// <returns code="200"></returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var videos = await _context.Videos
                .Include(v => v.Dvd)
                    .ThenInclude(d => d.Studio)
                .Include(v => v.Website)
                .Include(v => v.PerformerVideos)
                    .ThenInclude(pv => pv.Performer)
                        .ThenInclude(p => p.PerformerImages)
                            .ThenInclude(pi => pi.Image)
                .Include(v => v.VideoTags)
                    .ThenInclude(vt => vt.Tag)
                .ToListAsync();
            
            var videoVms = _mapper.Map<IList<Video>, IList<VideoDto>>(videos);
            return Ok(videoVms);
        }

        // GET api/videos/{id}
        /// <summary>
        /// Retrieves the video by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns code="200"></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var video = await _context.Videos
                .Include(v => v.Dvd)
                    .ThenInclude(d => d.Studio)
                .Include(v => v.Website)
                .Include(v => v.PerformerVideos)
                    .ThenInclude(pv => pv.Performer)
                        .ThenInclude(p => p.PerformerImages)
                            .ThenInclude(pi => pi.Image)
                .Include(v => v.VideoTags)
                    .ThenInclude(vt => vt.Tag)
                .Where(x => x.VideoId == id).SingleOrDefaultAsync();

            var videoVm = _mapper.Map<Video, VideoDto>(video);
            return Ok(videoVm);
        }

        //POST api/scene
        //[HttpPost, DisableRequestSizeLimit]
        //public async Task<IActionResult> Post(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);

        //    // full path to file in temp location
        //    var filePath = Path.GetTempFileName();

        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //        {
        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }

        //    return Ok(new { count = files.Count, size, filePath });
        //}
    }    
}


