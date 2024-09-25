using L8___Partial_view_og_View_component.Models;
using Microsoft.AspNetCore.Mvc;

namespace L8___Partial_view_og_View_component.Components
{
    public class VisEnPerson : ViewComponent
    {
        public IViewComponentResult Invoke(Person p)
        {
            p.Id += 10;
            return View(p);
        }
    }
}
