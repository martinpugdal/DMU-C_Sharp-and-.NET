using Microsoft.AspNetCore.Mvc;

namespace L6___MVC__Blazor_.Controllers
{
    public class RockbandsController : Controller
    {
        public IActionResult Index()
        {

            var rockbands = new List<string>
            {
                "Led Zeppelin",
                "The Beatles",
                "Pink Floyd",
                "Queen",
                "U2"
            };

            return View(new { Rockbands = rockbands });
        }
    }
}
