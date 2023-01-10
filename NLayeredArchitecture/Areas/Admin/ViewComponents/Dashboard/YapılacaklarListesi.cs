using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.Areas.Admin.ViewComponents.Dashboard
{
    public class YapılacaklarListesi:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
