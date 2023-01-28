using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.HizmetBasliklariList
{
    public class HizmetBasliklariList:ViewComponent
    {
        HizmetlerManager hm = new HizmetlerManager(new EfHizmetlerDal());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
