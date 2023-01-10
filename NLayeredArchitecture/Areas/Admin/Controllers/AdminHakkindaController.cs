using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminHakkinda")]
    public class AdminHakkindaController : Controller
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkımdaDal());

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = hm.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("HakkimdaDüzenle/{id}")]
        public IActionResult HakkimdaDüzenle(int id)
        {
            var values = hm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        [Route("HakkimdaDüzenle/{id}")]
        public IActionResult HakkimdaDüzenle(Hakkında p)
        {

            hm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
