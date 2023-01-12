using Core_Proje.Areas.Writers.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
	[Route("Admin/[controller]/[action]")]
	public class GirisPaneliController : Controller
	{
		private readonly SignInManager<Kullanici> _signInManager;

		public GirisPaneliController(SignInManager<Kullanici> signInManager)
		{
			_signInManager = signInManager;
		}


		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(GirisYapma p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, true, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Dashboard");
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
