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
        public IActionResult MovieSurvey()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieSurvey", new MovieSurvey());
        }

        [HttpPost]
        public IActionResult MovieSurvey(MovieSurvey response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to database
                _context.SaveChanges(); // save the record in the database

                return View("Confirmation", response);
            }
            else // Invalid Data
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

                return View(response);
            }
        }

        public IActionResult Collection()
        {
            // Linq
            var movies = _context.Movies
                .OrderBy(x => x.MovieId).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieSurvey", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieSurvey updatedInfo)
        {
            
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Collection");
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieSurvey record)
        {
            _context.Movies.Remove(record);
            _context.SaveChanges();

            return RedirectToAction("Collection");
        }
    }
}
