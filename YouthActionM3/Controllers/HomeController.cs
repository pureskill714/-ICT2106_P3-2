using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YouthActionM3.Models;

namespace YouthActionM3.Controllers
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

        public IActionResult ViewProjects()
        {
            return View();
        }

        public IActionResult ViewOrganization()
        {
            return View();
        }

        public IActionResult ViewNotification()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}