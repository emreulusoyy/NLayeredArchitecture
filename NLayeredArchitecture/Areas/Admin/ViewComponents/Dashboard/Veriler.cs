using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NLayeredArchitecture.Areas.Admin.ViewComponents.Dashboard
{
    public class Veriler : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Belgelers.Count();
            ViewBag.v3 = c.Hizmetlers.Count();
            return View();
        }
    }
}
