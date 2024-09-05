using Microsoft.AspNetCore.Mvc;

namespace L6___MVC__Blazor_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string Name = "Per";
            int Age = 23;
            DateTime Birthday = DateTime.Now;

            var viewObject = new
            {
                Name,
                Age,
                Birthday
            };

            return View(viewObject);
        }
    }
}
