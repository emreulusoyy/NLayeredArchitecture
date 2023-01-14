using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NLayeredArchitecture.Areas.Admin.Models;
using System.IO;
using System;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminAltSlider")]
    public class AdminAltSliderController : Controller
    {
        AltSliderManager asm = new AltSliderManager(new EfAltSliderDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = asm.TGetList();
            return View(values);         
        }

        [HttpGet]
        [Route("AltSliderDüzenle/{id}")]
        public IActionResult AltSliderDüzenle(int id)
        {
            var values = asm.TGetByID(id);
            SloganDuzenle blog = new SloganDuzenle()
            {
                AltSliderID = values.AltSliderID,
                SliderBaslik = values.SliderBaslik,
                SliderImage = values.SliderImage,

            };
            return View(blog);
        }

        [HttpPost]
        [Route("AltSliderDüzenle/{id}")]
        public async Task<IActionResult> AltSliderDüzenle(SloganDuzenle p)
        {
            var imagename = "";
            if (p.ImageFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/SloganResim/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            AltSlider blog = new AltSlider()
            {
                AltSliderID = p.AltSliderID,
                SliderBaslik = p.SliderBaslik,          
                SliderImage = imagename
            };
            asm.TUpdate(blog);
            return RedirectToAction("Index");
        }
    }
}
