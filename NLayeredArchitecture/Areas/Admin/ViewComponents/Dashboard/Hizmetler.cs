using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.ViewComponents.Dashboard
{
    public class Hizmetler:ViewComponent
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList(); 
            return View(values);
        }
    }
}
