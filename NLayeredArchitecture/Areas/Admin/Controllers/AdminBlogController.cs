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
                BlogBaslik = values.BlogBaslik,
                BlogTarih = values.BlogTarih,
                DevaminiOku = values.DevaminiOku,
                BlogImage = values.BlogImage
               


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
                var saveLocation = resource + "/wwwroot/HaberResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            Blog blog = new Blog()
            {
                BlogID = p.BlogID,
                BlogBaslik = p.BlogBaslik,
                BlogTarih = p.BlogTarih,
                DevaminiOku = p.DevaminiOku,
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
        [Route("BlogEkle")]
        public IActionResult BlogEkle()
        {


            return View();
        }

        [HttpPost]
        [Route("BlogEkle")]
        public async Task< IActionResult> BlogEkle(BlogDuzenle p)
        {
            var imagename = "";
            Blog b = new Blog();
            if(p.BlogImage!= null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(p.ImageFile.FileName);
                imagename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/HaberEkleResimleri/" + imagename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.ImageFile.CopyToAsync(stream);
            }
            b.BlogBaslik = p.BlogBaslik;
            b.BlogID = p.BlogID;
            b.DevaminiOku = p.DevaminiOku;
            b.BlogImage = p.BlogImage;
            b.BlogTarih = p.BlogTarih;

            bm.TAdd(b);
            return RedirectToAction("Index");

        }


    }
}

