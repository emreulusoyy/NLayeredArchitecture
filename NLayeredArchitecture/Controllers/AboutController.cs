using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class AboutController : Controller
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkımdaDal());
        public IActionResult Index()
        {
            var values = hm.TGetList();
            return View(values);
        }

        
    }
}
