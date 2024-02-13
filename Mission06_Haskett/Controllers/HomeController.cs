using Microsoft.AspNetCore.Mvc;
using Mission06_Haskett.Models;
using System.Diagnostics;

namespace Mission06_Haskett.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }

        public IActionResult Collection()
        {
            return View();
        }
    }
}
