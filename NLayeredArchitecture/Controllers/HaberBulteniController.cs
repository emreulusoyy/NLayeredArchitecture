using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]

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


        public IActionResult MailSil(int id)
        {
            var values = hm.GetByID(id);
            hm.Delete(values);

            return RedirectToAction("Index");
        }

    }
}
