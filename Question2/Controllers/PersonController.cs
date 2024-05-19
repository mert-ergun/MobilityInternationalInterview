using Microsoft.AspNetCore.Mvc;
using Question2.Data;
using Question2.Models;

namespace Question2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                await _context.SaveChangesAsync();
                return Ok(person);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] string name)
        {
            var person = _context.People.FirstOrDefault(p => p.Name == name);
            if (person != null)
            {
                _context.People.Remove(person);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            var people = _context.People.ToList();
            return Ok(people);
        }

        [HttpPost("Search")]
        public IActionResult Search([FromBody] string name)
        {
            var people = _context.People.Where(p => p.Name.Contains(name)).ToList();
            return Ok(people);
        }

    }
}
