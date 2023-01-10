using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    public class ContactController : Controller
    {
        IletisimManager ım = new IletisimManager(new EfIletisimDal());
        public IActionResult Index()
        {
            var values = ım.TGetList(); 
            return View(values);
        }
    }
}
