using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]

    public class DocumentsController : Controller
    {
        BelgelerManager bm = new BelgelerManager(new EfBelgelerDal());
        public IActionResult Index()
        {
            var values = bm.TGetList();
            return View(values);
        }
    }
}
