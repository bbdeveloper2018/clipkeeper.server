using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClipKeeper.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClipKeeper.Server.WebService.Controllers
{
    [Route("api/[controller]")]
    public class StarController : Controller
    {
        private readonly ClipKeeperContext _context;
        public StarController(ClipKeeperContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Stars.ToListAsync());
        }

       
    }
}
