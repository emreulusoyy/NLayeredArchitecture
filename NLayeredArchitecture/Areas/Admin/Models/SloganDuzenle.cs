using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class SloganDuzenle
    {
        public int AltSliderID { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderImage { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
