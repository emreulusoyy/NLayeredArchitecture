using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.Areas.Admin.Models;

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
            BelgelerDüzenle belge = new BelgelerDüzenle()
            {
                BelgeID = values.BelgeID,
                BelgeImage = values.BelgeImage,
                BelgeAcilirImage = values.BelgeAcilirImage,
                

            };

            return View(belge);
          
        }

        [HttpPost]
        [Route("BelgelerDüzenle/{id}")]
        public IActionResult BelgelerDüzenle(Belgeler p)
        {

            bm.TUpdate(p);
            return RedirectToAction("Index");
        }

        [Route("BelgeSil/{id}")]
        public IActionResult BelgeSil(int id)
        {
            var values = bm.TGetByID(id);
            bm.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("BelgeEkle/{id}")]
        public IActionResult BelgeEkle()
        {

            return View();
        }

        [HttpPost]
        [Route("BelgeEkle/{id}")]
        public IActionResult BelgeEkle(Belgeler p)
        {
            bm.TAdd(p);
            return RedirectToAction("Index");

        }
    }
}
