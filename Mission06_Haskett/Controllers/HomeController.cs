using Microsoft.AspNetCore.Mvc;
using Mission06_Haskett.Models;
using System.Diagnostics;

namespace Mission06_Haskett.Controllers
{
    public class HomeController : Controller
    {
        private MovieSurveyContext _context;
        public HomeController(MovieSurveyContext temp) // Constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Collection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collection(MovieSurvey response)
        {
            _context.Movies.Add(response); // Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
