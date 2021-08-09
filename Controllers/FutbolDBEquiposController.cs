using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFutbolTorneo.Entities;
using ApiFutbolTorneo.Service;

namespace ApiFutbolTorneo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolDBEquiposController : ControllerBase
    {
        private readonly FutbolDBContext _context;

        public FutbolDBEquiposController(FutbolDBContext context)
        {
            _context = context;
        }

        


        
        // GET: api/FutbolDBEquipos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FutbolDBEquipos>>> GetFutbolDBEquipos()
        {
            return await _context.FutbolDBEquipos.ToListAsync();
        }

        // GET: api/FutbolDBEquipos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FutbolDBEquipos>> GetFutbolDBEquipos(int id)
        {
            var futbolDBEquipos = await _context.FutbolDBEquipos.FindAsync(id);

            if (futbolDBEquipos == null)
            {
                return NotFound();
            }

            return futbolDBEquipos;
        }

        // PUT: api/FutbolDBEquipos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFutbolDBEquipos(int id, FutbolDBEquipos futbolDBEquipos)
        {
            if (id != futbolDBEquipos.id)
            {
                return BadRequest();
            }

            _context.Entry(futbolDBEquipos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FutbolDBEquiposExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FutbolDBEquipos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FutbolDBEquipos>> PostFutbolDBEquipos(FutbolDBEquipos futbolDBEquipos)
        {
            _context.FutbolDBEquipos.Add(futbolDBEquipos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFutbolDBEquipos", new { id = futbolDBEquipos.id }, futbolDBEquipos);
        }

        // DELETE: api/FutbolDBEquipos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFutbolDBEquipos(int id)
        {
            var futbolDBEquipos = await _context.FutbolDBEquipos.FindAsync(id);
            if (futbolDBEquipos == null)
            {
                return NotFound();
            }

            _context.FutbolDBEquipos.Remove(futbolDBEquipos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FutbolDBEquiposExists(int id)
        {
            return _context.FutbolDBEquipos.Any(e => e.id == id);
        }
    }
}
