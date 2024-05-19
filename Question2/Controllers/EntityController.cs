using Microsoft.AspNetCore.Mvc;
using Question2.Data;
using Question2.Models;

namespace Question2.Controllers
{
    public class EntityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EntityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Person person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(person);
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string name)
        {
            var person = _context.People.FirstOrDefault(p => p.Name == name);
            if (person != null)
            {
                _context.People.Remove(person);
                await _context.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View();
        }

        public IActionResult List()
        {
            var people = _context.People.ToList();
            return View(people);
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string name)
        {
            var people = _context.People.Where(p => p.Name.Contains(name)).ToList();
            return View("List", people);
        }
    }

}
