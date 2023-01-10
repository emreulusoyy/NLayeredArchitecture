using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Route("Admin/AdminHizmetler")]
    public class AdminHizmetlerController : Controller
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = hm.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("HizmetlerDüzenle/{id}")]
        public IActionResult HizmetlerDüzenle(int id)
        {
            var values = hm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("HizmetlerDüzenle/{id}")]
        public IActionResult HizmetlerDüzenle(Hizmetler p)
        {

            hm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
