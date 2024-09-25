using L8___Partial_view_og_View_component.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace L8___Partial_view_og_View_component.Controllers
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

        List<Person> AllePersoner()
        {
            List<Person> people =
            [
                new Person(1, "John Doe"),
                new Person(2, "Jane Smith"),
                new Person(3, "Michael Johnson"),
                new Person(4, "Emily Davis"),
                new Person(5, "William Brown"),
                new Person(6, "Olivia Wilson"),
                new Person(7, "James Martinez"),
                new Person(8, "Sophia Taylor"),
                new Person(9, "Benjamin Anderson"),
                new Person(10, "Ava Thomas"),
                new Person(11, "Liam Harris"),
                new Person(12, "Charlotte Lee"),
                new Person(13, "Lucas White"),
                new Person(14, "Amelia Thompson"),
                new Person(15, "Mason Clark")
            ];
            return people;
        }

        public IActionResult VisAlle()
        {
            return View(AllePersoner());
        }

        public IActionResult VisEn()
        {
            Random rng = new();
            List<Person> personer = AllePersoner();
            // shuffle the list
            personer = [.. personer.OrderBy(_ => rng.Next())];
            return View(personer.First());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
