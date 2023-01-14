using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.UstLayoutIletisim
{
    public class UstIletisimList:ViewComponent
    {
        IletisimManager im = new IletisimManager(new EfIletisimDal());
        public IViewComponentResult Invoke()
        {
            var values = im.TGetList();
            return View(values);
        }
    }
}
