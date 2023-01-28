using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]

    public class AltSliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
