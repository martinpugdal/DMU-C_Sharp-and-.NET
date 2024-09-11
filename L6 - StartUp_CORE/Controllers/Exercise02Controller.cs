using Microsoft.AspNetCore.Mvc;
using StartUp_CORE.Models;

namespace Lesson02_Startup.Controllers
{
    public class Exercise02Controller : Controller
    {


        public ActionResult Index()
        {

            var personer = new List<Person>
            {
                new("Hej1", "Farvel", DateTime.Now.AddYears(-10), ["12345675"], "Hjemvej 1", "1234", "Toast"),
                new("Hej2", "Farvel", DateTime.Now.AddYears(-14), ["12345674"], "Hjemvej 3", "1234", "Toast"),
                new("Hej3", "Farvel", DateTime.Now.AddYears(-16), ["12345673"], "Hjemvej 5", "1234", "Toast"),
                new("Hej4", "Farvel", DateTime.Now.AddYears(-27), ["12345672"], "Hjemvej 7", "1234", "Toast"),
                new("Hej5", "Farvel", DateTime.Now.AddYears(-40), ["12345671"], "Hjemvej 9", "1234", "Toast")
            };

            personer.First().AddPhone("21721831");

            ViewBag.Personer = personer;

            return View();
        }

    }
}
