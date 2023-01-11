using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NLayeredArchitecture.ViewComponents.Hakkımda
{
    public class HakkımdaList:ViewComponent
    {
        HakkindaManager hm = new HakkindaManager(new EfHakkımdaDal());
        public IViewComponentResult Invoke()
        {
            var values = hm.TGetList();
            return View(values);
        }
    }
}
