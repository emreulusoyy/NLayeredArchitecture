using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.Areas.Admin.Models;
using System.IO;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

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
                BelgeBaslik = values.BelgeBaslik
                

            };

            return View(belge);
          
        }

        [HttpPost]
        [Route("BelgelerDüzenle/{id}")]
        public async Task< IActionResult> BelgelerDüzenle(BelgelerDüzenle p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/BelgeResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            Belgeler belge = new Belgeler()
            {
                BelgeID = p.BelgeID,
                BelgeImage = imagename,
                BelgeAcilirImage = p.BelgeAcilirImage,
                BelgeBaslik = p.BelgeBaslik
            };
            bm.TUpdate(belge);
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
        [Route("BelgeEkle")]
        public IActionResult BelgeEkle()
        {

            return View();
        }

        [HttpPost]
        [Route("BelgeEkle")]
        public async Task< IActionResult> BelgeEkle(BelgelerDüzenle p)
        {
            var imagename = "";
            Belgeler b = new Belgeler();
            if (p.BelgeImage != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/BelgeResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            b.BelgeBaslik = p.BelgeBaslik;
            b.BelgeID = p.BelgeID;
            b.BelgeAcilirImage = p.BelgeAcilirImage;
            b.BelgeImage = p.BelgeImage;
            bm.TAdd(b);
            return RedirectToAction("Index");

        }
    }
}
