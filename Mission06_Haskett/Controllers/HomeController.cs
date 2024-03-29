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
        public IActionResult Index() // For the index page view and action
        {
            return View();
        }

        public IActionResult KnowJoel() // For the Get to Knoow Joel Page. Just return the same file.
        {
            return View();
        }

        [HttpGet] // Get and Post methods to submit the form and post it to the database
        public IActionResult Collection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collection(MovieSurvey response)
        {
            _context.Movies.Add(response); // Add record to database
            _context.SaveChanges(); // save the record in the database

            return View("Confirmation", response);
        }
    }
}
