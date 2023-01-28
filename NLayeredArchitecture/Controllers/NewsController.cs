using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]
    public class NewsController : Controller
    {
        

        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var values = bm.TGetList();
            return View(values);
        }
    }
}
