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
    public class FutbolDBJugadorasController : ControllerBase
    {
        private readonly FutbolDBContext _context;

        public FutbolDBJugadorasController(FutbolDBContext context)
        {
            _context = context;
        }

        // GET: api/FutbolDBJugadoras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FutbolDBJugadoras>>> GetFutbolDBJugadoras()
        {
            return await _context.FutbolDBJugadoras.ToListAsync();
        }

        // GET: api/FutbolDBJugadoras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FutbolDBJugadoras>> GetFutbolDBJugadoras(int id)
        {
            var futbolDBJugadoras = await _context.FutbolDBJugadoras.FindAsync(id);

            if (futbolDBJugadoras == null)
            {
                return NotFound();
            }

            return futbolDBJugadoras;
        }

        // GET: api/FutbolDBJugadoras/multiple/equipo
        [HttpGet("multiple/{equipo}")]
        public async Task<List<FutbolDBJugadoras>> GetFutbolDBJugadoras(string equipo)
        {
            var futbolDBJugadoras = await _context.FutbolDBJugadoras.Where(b => b.equipojugando.Contains(equipo)).ToListAsync();

            if (futbolDBJugadoras == null)
            {
                new ArgumentException("No existe jugadoras con ese equipo");
            }

            return futbolDBJugadoras;
        }

        // PUT: api/FutbolDBJugadoras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFutbolDBJugadoras(int id, FutbolDBJugadoras futbolDBJugadoras)
        {
            if (id != futbolDBJugadoras.id)
            {
                return BadRequest();
            }


            _context.Entry(futbolDBJugadoras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FutbolDBJugadorasExists(id))
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

        // POST: api/FutbolDBJugadoras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FutbolDBJugadoras>> PostFutbolDBJugadoras(FutbolDBJugadoras futbolDBJugadoras)
        {

            //VALIDO SI EXISTE EL EQUIPO EN EL CUAL SE QUIERE INSERTAR LA JUGADORA EXISTE
            var EquipoAJugar = await _context.FutbolDBEquipos.Where(b => b.equipo.Contains(futbolDBJugadoras.equipojugando)).ToListAsync();
            if ((EquipoAJugar.Count()) < 1)
            {
                throw new ArgumentException("El equipo donde se quiere insertar a la jugadora no existe");
            }


            //VALIDO SI HAY MAS DE 11 JUGADORAS EN EL EQUIPO, EN TAL CASO NO PERMITO HACER LA INSERCCIÓN
            //DEL REGISTRO
            var cantJugadoras = await _context.FutbolDBJugadoras.Where(b => b.equipojugando.Contains(futbolDBJugadoras.equipojugando)).ToListAsync();
            if ((cantJugadoras.Count()) > 10)
            {
                throw new ArgumentException("Cantidad máxima de jugadoras sobrepasada");
            }




            _context.FutbolDBJugadoras.Add(futbolDBJugadoras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFutbolDBJugadoras", new { id = futbolDBJugadoras.id }, futbolDBJugadoras);
        }

        // DELETE: api/FutbolDBJugadoras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFutbolDBJugadoras(int id)
        {
            var futbolDBJugadoras = await _context.FutbolDBJugadoras.FindAsync(id);
            if (futbolDBJugadoras == null)
            {
                return NotFound();
            }

            _context.FutbolDBJugadoras.Remove(futbolDBJugadoras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FutbolDBJugadorasExists(int id)
        {
            return _context.FutbolDBJugadoras.Any(e => e.id == id);
        }
    }
}
