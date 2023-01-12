//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System.IO;
//using System.Threading.Tasks;
//using System;
//using EntityLayer.Concrete;
//using NLayeredArchitecture.Areas.Admin.Models;

//namespace NLayeredArchitecture.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    [Route("Admin/Profile")]

//    public class ProfileController : Controller
//    {
//        private readonly UserManager<Kullanici> _userManager;

//        public ProfileController(UserManager<Kullanici> userManager)
//        {
//            _userManager = userManager;
//        }


//        [Route("")]
//        [Route("Index")]
//        public async Task<IActionResult> Index()
//        {
//            return View();
//            var values = await _userManager.FindByNameAsync(User.Identity.Name);
//            KullaniciDüzenle model = new KullaniciDüzenle();
//            model.Name = values.Name;
//            model.Surname = values.Surname;
//            model.UserName = values.UserName;
//            return View(model);
//        }
//        [HttpPost]
//        //public async Task<IActionResult> Index(p)
//        //{
//        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
//        //    if (p.Picture != null)
//        //    {
//        //        var resource = Directory.GetCurrentDirectory();
//        //        var extension = Path.GetExtension(p.Picture.FileName);
//        //        var imagename = Guid.NewGuid() + extension;
//        //        var savelocation = resource + "/wwwroot/userimage/" + imagename;
//        //        var stream = new FileStream(savelocation, FileMode.Create);
//        //        await p.Picture.CopyToAsync(stream);
//        //        user.ImageUrl = imagename;
//        //    }
//        //    user.Name = p.Name;
//        //    user.Surname = p.Surname;
//        //    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
//        //    var result = await _userManager.UpdateAsync(user);
//        //    if (result.Succeeded)
//        //    {
//        //        return RedirectToAction("Index", "Login");
//        //    }
//        //    return View();
//        //}
//    }
//}
