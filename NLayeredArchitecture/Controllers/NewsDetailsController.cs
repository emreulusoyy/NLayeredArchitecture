using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class NewsDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
