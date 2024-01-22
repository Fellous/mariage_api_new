using Microsoft.AspNetCore.Mvc;
using mariage_api_new.Data;
using mariage_api_new.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace mariage_api_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InvitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/invites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invite>>> GetInvites()
        {
            return await _context.Invites.ToListAsync();
        }

        // GET: api/invites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invite>> GetInvite(int id)
        {
            var invite = await _context.Invites.FindAsync(id);

            if (invite == null)
            {
                return NotFound();
            }

            return invite;
        }

        // POST: api/invites
        [HttpPost]
        public async Task<ActionResult<Invite>> PostInvite(Invite invite)
        {
            _context.Invites.Add(invite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvite", new { id = invite.Id }, invite);
        }

        // PUT: api/invites/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvite(int id, Invite invite)
        {
            if (id != invite.Id)
            {
                return BadRequest();
            }

            _context.Entry(invite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InviteExists(id))
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

        // DELETE: api/invites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvite(int id)
        {
            var invite = await _context.Invites.FindAsync(id);
            if (invite == null)
            {
                return NotFound();
            }

            _context.Invites.Remove(invite);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InviteExists(int id)
        {
            return _context.Invites.Any(e => e.Id == id);
        }
    }
}
