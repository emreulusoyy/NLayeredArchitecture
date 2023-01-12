using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.Areas.Admin.Models;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminKayıt")]
    public class AdminKayıtController : Controller
    {
        private readonly UserManager<Kullanici> _userManager;

        public AdminKayıtController(UserManager<Kullanici> userManager)
        {
            _userManager = userManager;
        }

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Index")]
        [HttpPost]
        public async Task< IActionResult> Index(AdminKayitPaneli p)
        {
            if (ModelState.IsValid)
            {
                Kullanici w = new Kullanici()
                {
                    Name = p.Ad,
                    Surname = p.Soyad,
                    Email = p.Mail,
                    UserName = p.UserName
                };
                var result = await _userManager.CreateAsync(w, p.PassWord);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
               

            }
            return View(p);
            
        }

    }
}
