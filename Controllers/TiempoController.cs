using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tiempo;
using Tiempo.Models;

namespace Tiempo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiempoController : ControllerBase
    {
        private readonly TiempoContext _context;

        public TiempoController(TiempoContext context)
        {
            _context = context;
        }

        // GET: api/Tiempo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiempoItem>>> GetTiempo()
        {
            return await _context.Tiempo.ToListAsync();
        }

        // GET: api/Tiempo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiempoItem>> GetTiempoItem(string id)
        {
            var tiempo = await _context.Tiempo.FindAsync(id);

            if (tiempo == null)
            {
                return NotFound();
            }

            return tiempo;
        }
        private bool TiempoExists(string id)
        {
            return _context.Tiempo.Any(e => e.Municipio == id);
        }
    }
}