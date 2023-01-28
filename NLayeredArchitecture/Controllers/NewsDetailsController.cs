using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]
    public class NewsDetailsController : Controller
    {
       

        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index(int id)
        {
            var values = bm.TGetByID(id);
            return View(values);
        }
    }
}
