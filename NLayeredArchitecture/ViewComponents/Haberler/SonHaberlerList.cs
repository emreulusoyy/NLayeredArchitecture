using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NLayeredArchitecture.ViewComponents.Haberler
{
    public class SonHaberlerList:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
          var values=  bm.TGetList().OrderByDescending(x=>x.BlogID).Take(2).ToList();
            return View(values);
        }
    }
}
