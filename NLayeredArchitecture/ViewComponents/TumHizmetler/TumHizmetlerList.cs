using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.TümHizmetler
{
    public class TumHizmetlerList:ViewComponent
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);    
        }
    }
}
