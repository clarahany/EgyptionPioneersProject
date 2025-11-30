using System.Diagnostics;
using EgyptionPioneersProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgyptionPioneersProject.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        
        public IActionResult SkinDiseases()
        {
            return View();
        }
        public IActionResult DailySkinRoutine()
        {
            return View();
        }

        // Skin Tips Page
        public IActionResult SkinTips()
        {
            return View();
        }
    }
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
