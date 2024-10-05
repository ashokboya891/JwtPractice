using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JwtWebApiTutorial.DatabaseContext;
using JwtWebApiTutorial.Models;
using Microsoft.AspNetCore.Authorization;

namespace JwtWebApiTutorial.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CitiysController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Citiys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citiy>>> GetCityTbl()
        {
          if (_context.CityTbl == null)
          {
              return NotFound();
          }
            return await _context.CityTbl.ToListAsync();
        }

        // GET: api/Citiys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Citiy>> GetCitiy(Guid id)
        {
          if (_context.CityTbl == null)
          {
              return NotFound();
          }
            var citiy = await _context.CityTbl.FindAsync(id);

            if (citiy == null)
            {
                return NotFound();
            }

            return citiy;
        }

        // PUT: api/Citiys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitiy(Guid id, Citiy citiy)
        {
            if (id != citiy.CityId)
            {
                return BadRequest();
            }

            _context.Entry(citiy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitiyExists(id))
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

        // POST: api/Citiys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Citiy>> PostCitiy(Citiy citiy)
        {
          if (_context.CityTbl == null)
          {
              return Problem("Entity set 'ApplicationDbContext.CityTbl'  is null.");
          }
            _context.CityTbl.Add(citiy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCitiy", new { id = citiy.CityId }, citiy);
        }

        // DELETE: api/Citiys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitiy(Guid id)
        {
            if (_context.CityTbl == null)
            {
                return NotFound();
            }
            var citiy = await _context.CityTbl.FindAsync(id);
            if (citiy == null)
            {
                return NotFound();
            }

            _context.CityTbl.Remove(citiy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitiyExists(Guid id)
        {
            return (_context.CityTbl?.Any(e => e.CityId == id)).GetValueOrDefault();
        }
    }
}
