using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    
    public class HaberBulteniController : Controller
    {
        HaberBulteniManager hm = new HaberBulteniManager(new EfHaberBulteniDal());
        [HttpPost]
        public IActionResult SaveMail(HaberBulteni p)
        {
            hm.Insert(p);
            return RedirectToAction("Index","HomePage");
        }
        
       public IActionResult Index()
        {
            var values = hm.GetList();
            return View(values);    
        }

    }
}
