using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Online_Quiz_Application.Data;
using System.Linq;
using System.Threading.Tasks;
using Online_Quiz_Application.Models;

namespace Online_Quiz_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResultController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/result/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetResultWithDetails(int id)
        {
            var result = await _context.Results
                .Include(r => r.User)  // Include related User
                .Include(r => r.Quiz)  // Include related Quiz
                    .ThenInclude(q => q.Questions)  // Include Questions for the Quiz
                        .ThenInclude(q => q.Options)  // Include Options for each Question
                .FirstOrDefaultAsync(r => r.ResultID == id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}
