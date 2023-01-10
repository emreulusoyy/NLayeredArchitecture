using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class NewsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
