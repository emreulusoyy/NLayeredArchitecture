using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminSlider")]
    public class AdminSliderController : Controller
    {
        SliderManager sm = new SliderManager(new EfSliderDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = sm.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("SliderDüzenle/{id}")]
        public IActionResult SliderDüzenle(int id)
        {
            var values = sm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("SliderDüzenle/{id}")]
        public IActionResult SliderDüzenle(Slider p)
        {

            sm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
