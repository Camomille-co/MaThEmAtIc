using MaThEmAtIc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaThEmAtIc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FOS()
        {
            return View("FOS");
        }

        public IActionResult Homework()
        {
            return View("Homework");
        }

        public IActionResult Lectures()
        {
            return View("Lectures");
        }

        public IActionResult RPD()
        {
            return View("RPD");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
