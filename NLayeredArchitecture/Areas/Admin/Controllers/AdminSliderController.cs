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
        public  IActionResult SliderDüzenle(int id)
        {

            var values = sm.TGetByID(id);
           
            AnaSlider slider = new AnaSlider()
            {
                SliderID = values.SliderID,
                SliderBaslik = values.SliderBaslik,
                SliderAltBaslik = values.SliderAltBaslik,
                SliderImage = values.SliderImage,
            };
            return View(slider);
        }

        [HttpPost]
        [Route("SliderDüzenle/{id}")]
        public async Task< IActionResult> SliderDüzenle(AnaSlider p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/SliderImages/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            Slider slider = new Slider()
            {
                SliderID = p.SliderID,
                SliderBaslik = p.SliderBaslik,
                SliderAltBaslik = p.SliderAltBaslik,
                SliderImage = imagename

            };

            sm.TUpdate(slider);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("SliderEkle")]
        public IActionResult SliderEkle()
        {

            return View();
        }

        [HttpPost]
        [Route("SliderEkle")]
        public IActionResult SliderEkle(Slider p)
        {
            sm.TAdd(p);
            return RedirectToAction("Index");

        }

        [Route("SliderSil/{id}")]
        public IActionResult SliderSil(int id)
        {
            var values = sm.TGetByID(id);
            sm.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
