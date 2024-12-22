using System.Diagnostics;
using giftbox.Data;
using giftbox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace giftbox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees= await _context.Employees.ToListAsync();
            return View(employees);
        }

        public async Task<IActionResult> Lottery()
        {
            var randomEmployee = await _context.Employees
                                               .OrderBy(e => Guid.NewGuid())  // Randomize the list
                                               .FirstOrDefaultAsync();        // Get the first one

            if (randomEmployee == null)
            {
                return NotFound("No employees found.");
            }

            return Json(randomEmployee); // Return as JSON to be used in the frontend
        }

    }
}
