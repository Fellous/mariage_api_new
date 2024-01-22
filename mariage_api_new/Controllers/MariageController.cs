using Microsoft.AspNetCore.Mvc;
using mariage_api_new.Data;
using mariage_api_new.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace mariage_api_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MariagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MariagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/mariages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mariage>>> GetMariages()
        {
            return await _context.Mariages.ToListAsync();
        }

        // GET: api/mariages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mariage>> GetMariage(int id)
        {
            var mariage = await _context.Mariages.FindAsync(id);

            if (mariage == null)
            {
                return NotFound();
            }

            return mariage;
        }

        // POST: api/mariages
        [HttpPost]
        public async Task<ActionResult<Mariage>> PostMariage(Mariage mariage)
        {
            _context.Mariages.Add(mariage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMariage", new { id = mariage.Id }, mariage);
        }

        // PUT: api/mariages/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMariage(int id, Mariage mariage)
        {
            if (id != mariage.Id)
            {
                return BadRequest();
            }

            _context.Entry(mariage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MariageExists(id))
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

        // DELETE: api/mariages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMariage(int id)
        {
            var mariage = await _context.Mariages.FindAsync(id);
            if (mariage == null)
            {
                return NotFound();
            }

            _context.Mariages.Remove(mariage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MariageExists(int id)
        {
            return _context.Mariages.Any(e => e.Id == id);
        }
    }
}
