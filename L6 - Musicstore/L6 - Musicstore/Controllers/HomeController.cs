using L6___Musicstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L6___Musicstore.Controllers
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
    }
}
