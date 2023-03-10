using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]
    public class ServicesDetailsController : Controller
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        public IActionResult Index(int id)
        {
            var values = hm.TGetByID(id);
            return View(values);
        }

       
    }
}
