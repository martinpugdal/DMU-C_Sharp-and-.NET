using L8___Layouts__partials_views___view_components.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L8___Layouts__partials_views___view_components.Controllers
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

        public IActionResult Sale()
        {
            return View();
        }

        public IActionResult MoreSale()
        {
            return View();
        }

        public IActionResult Buy()
        {
            return View();
        }

        public IActionResult BuyAndSell()
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
