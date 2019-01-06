using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClipKeeper.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClipKeeper.Server.WebService.Controllers
{
    /// <summary>
    /// Performer API
    /// </summary>
    [Route("api/[controller]")]
    public class PerformersController : Controller
    {
        private readonly ClipKeeperContext _context;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes the database context and Automapper.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public PerformersController(ClipKeeperContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Retrieves a list of all performers.
        /// </summary>
        /// <returns code="200"></returns>
        // GET: api/perfromers
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Performers.ToListAsync());
        }       
    }
}
