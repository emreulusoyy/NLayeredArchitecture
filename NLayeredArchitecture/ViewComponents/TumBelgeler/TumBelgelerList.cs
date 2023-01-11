using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.TumBelgeler
{
    public class TumBelgelerList:ViewComponent
    {
        BelgelerManager bm = new BelgelerManager(new EfBelgelerDal());
        public IViewComponentResult Invoke()
        {
            var values = bm.TGetList();
            return View(values);    
        }
    }
}
