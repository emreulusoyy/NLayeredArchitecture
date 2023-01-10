using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class ServicesDetailsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
