using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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
            return View(values);
        }

        [HttpPost]
        [Route("BlogDüzenle/{id}")]
        public IActionResult BlogDüzenle(Blog p)
        {

            bm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
