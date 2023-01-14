using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminiletisimSayfası")]
    public class AdminiletisimSayfasıController : Controller
    {
        IletisimManager im = new IletisimManager(new EfIletisimDal());

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = im.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("iletisimDüzenle/{id}")]
        public IActionResult iletisimDüzenle(int id)
        {
            var values = im.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("iletisimDüzenle/{id}")]
        public IActionResult iletisimDüzenle(Iletisim p)
        {

            im.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
