using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.AltSlider
{
    public class AltSliderList : ViewComponent
    {
        AltSliderManager asm = new AltSliderManager(new EfAltSliderDal());
        public IViewComponentResult Invoke()
        {
            var values = asm.TGetList();
            return View(values);
        }

    }
}
