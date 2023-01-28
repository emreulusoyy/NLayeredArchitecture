using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]
    public class HomePageController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }
    }
}
