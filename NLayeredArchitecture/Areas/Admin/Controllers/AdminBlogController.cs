using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using NLayeredArchitecture.Areas.Admin.Models;
using System.Threading.Tasks;

namespace NLayeredArchitecture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminBlog")]
    public class AdminBlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = bm.TGetList();
            return View(values);
        }

        [HttpGet]
        [Route("BlogDüzenle/{id}")]
        public IActionResult BlogDüzenle(int id)
        {
            var values = bm.TGetByID(id);
            BlogDuzenle blog = new BlogDuzenle()
            {
                BlogID = values.BlogID,
                AltBaslik = values.AltBaslik,
                AnaBaslik = values.AnaBaslik,
                BlogBaslik = values.BlogBaslik,
                BlogTarih = values.BlogTarih,
             
            };

            return View(blog);
        }

        [HttpPost]
        [Route("BlogDüzenle/{id}")]
        public async Task< IActionResult> BlogDüzenle(BlogDuzenle p)
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
            Blog blog = new Blog()
            {
                BlogID = p.BlogID,
                AltBaslik = p.AltBaslik,
                AnaBaslik = p.AnaBaslik,
                BlogBaslik = p.BlogBaslik,
                BlogTarih = p.BlogTarih,
                BlogImage = imagename
                
            };


            bm.TUpdate(blog);
            return RedirectToAction("Index");
        }

        [Route("BlogSil/{id}")]
        public IActionResult BlogSil(int id)
        {
            var values = bm.TGetByID(id);
            bm.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("BlogEkle/{id}")]
        public IActionResult BlogEkle()
        {

            return View();
        }

        [HttpPost]
        [Route("BlogEkle/{id}")]
        public IActionResult BlogEkle(Blog p)
        {
            bm.TAdd(p);
            return RedirectToAction("Index");

        }


    }
}

