using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
