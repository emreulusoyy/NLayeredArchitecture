using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class AnaSlider
    {
        public int SliderID { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderAltBaslik { get; set; }
        public string SliderImage { get; set; }
        public IFormFile ImageFile { get; set; }    
    }
}
