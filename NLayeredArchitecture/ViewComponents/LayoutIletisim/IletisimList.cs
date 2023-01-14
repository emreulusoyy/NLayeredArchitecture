using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.LayoutIletisimList
{
    public class IletisimList : ViewComponent
    {
        IletisimManager im = new IletisimManager(new EfIletisimDal());
        public IViewComponentResult Invoke()
        {
            var values = im.TGetList();
            return View(values);
        }
    }
}
