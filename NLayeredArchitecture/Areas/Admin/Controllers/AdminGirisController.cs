using Core_Proje.Areas.Writers.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminGiris")]
    public class AdminGirisController : Controller
    {
        private readonly SignInManager<Kullanici> _signInManager;

        public AdminGirisController(SignInManager<Kullanici> signInManager)
        {
            _signInManager = signInManager;
        }
        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

       

        [HttpPost]
        public async Task<IActionResult> Index(AdminGiriş p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }
    }
}
