using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {


        public ActionResult Index()
        {
            Product glass = new("Wine glass", 160.50, "grandcru.jpg", "1");
            Product bin = new("Bin", 10.20, "bin_35l.jpg", "2");
            Product knife = new("Knife", 12.4, "st_knife.jpg", "3");


            ViewBag.Glass = glass;
            ViewBag.Bin = bin;
            ViewBag.Knife = knife;

            return View();
        }

    }
}
