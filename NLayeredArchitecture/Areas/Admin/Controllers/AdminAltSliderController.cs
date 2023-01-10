using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminAltSlider")]
    public class AdminAltSliderController : Controller
    {
        AltSliderManager asm = new AltSliderManager(new EfAltSliderDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = asm.TGetList();
            return View(values);         
        }

        [HttpGet]
        [Route("AltSliderDüzenle/{id}")]
        public IActionResult AltSliderDüzenle(int id)
        {
            var values = asm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("AltSliderDüzenle/{id}")]
        public IActionResult AltSliderDüzenle(AltSlider p)
        {

            asm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
