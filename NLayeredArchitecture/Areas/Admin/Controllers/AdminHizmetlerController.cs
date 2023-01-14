using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.Areas.Admin.Models;
using System.IO;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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
            HizmetlerDuzenle hizmet = new HizmetlerDuzenle()
            {
                HizmetlerID = values.HizmetlerID,
                HizmetlerBaslik = values.HizmetlerBaslik,
                HizmetlerAcıklama = values.HizmetlerAcıklama,
                HizmetlerImage = values.HizmetlerImage         
            };
            return View(hizmet);
        }

        [HttpPost]
        [Route("HizmetlerDüzenle/{id}")]
        public async Task<IActionResult> HizmetlerDüzenle(HizmetlerDuzenle p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/HizmetResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            Hizmetler hizmet = new Hizmetler()
            {
                HizmetlerID = p.HizmetlerID,
                HizmetlerBaslik = p.HizmetlerBaslik,
                HizmetlerAcıklama = p.HizmetlerAcıklama,
                HizmetlerImage = imagename

            };

            hm.TUpdate(hizmet);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("HizmetEkle")]
        public IActionResult HizmetEkle()
        {

            return View();
        }

        [HttpPost]
        [Route("HizmetEkle")]
        public async Task< IActionResult> HizmetEkle(HizmetlerDuzenle p)
        {
            var imagename = "";
            Hizmetler b = new Hizmetler();
            if (p.HizmetlerImage != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/HizmetResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            b.HizmetlerBaslik = p.HizmetlerBaslik;
            b.HizmetlerID = p.HizmetlerID;
            b.HizmetlerAcıklama = p.HizmetlerAcıklama;
            b.HizmetlerImage = p.HizmetlerImage;

            hm.TAdd(b);
            return RedirectToAction("Index");

        }

        [Route("HizmetSil/{id}")]
        public IActionResult HizmetSil(int id)
        {
            var values = hm.TGetByID(id);
            hm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
