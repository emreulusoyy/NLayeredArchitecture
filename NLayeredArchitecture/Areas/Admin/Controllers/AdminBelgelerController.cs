using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminBelgeler")]
    public class AdminBelgelerController : Controller
    {
        BelgelerManager bm = new BelgelerManager(new EfBelgelerDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = bm.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("BelgelerDüzenle/{id}")]
        public IActionResult BelgelerDüzenle(int id)
        {
            var values = bm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("BelgelerDüzenle/{id}")]
        public IActionResult BelgelerDüzenle(Belgeler p)
        {

            bm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
