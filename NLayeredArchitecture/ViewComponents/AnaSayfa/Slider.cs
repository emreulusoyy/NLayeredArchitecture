using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.AnaSayfa
{

    public class Slider : ViewComponent
    {
        SliderManager sm = new SliderManager(new EfSliderDal());
        public IViewComponentResult Invoke()
        {
            var values = sm.TGetList();
            return View(values);
        }

    }
}
