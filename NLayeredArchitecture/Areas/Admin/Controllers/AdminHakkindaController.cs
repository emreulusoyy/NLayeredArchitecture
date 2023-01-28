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
            HakkimdaDüzenle blog = new HakkimdaDüzenle()
            {
                HakkındaID = values.HakkındaID,
                HakkındaBaslik = values.HakkındaBaslik,
                HakkındaAcıklama = values.HakkındaAcıklama,
                HakkındaImage = values.HakkındaImage,
            };

            return View(blog);
        }

        [HttpPost]
        [Route("HakkimdaDüzenle/{id}")]
        public async Task< IActionResult> HakkimdaDüzenle(HakkimdaDüzenle p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/HakkindaResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            if (p.HakkındaImage != null)
            {
                imagename = p.HakkındaImage;
            }
            Hakkında blog = new Hakkında()
            {
                HakkındaID = p.HakkındaID,
                HakkındaBaslik = p.HakkındaBaslik,
                HakkındaAcıklama = p.HakkındaAcıklama,
                HakkındaImage = imagename
            };

            hm.TUpdate(blog);
            return RedirectToAction("Index");
        }
    }
}
