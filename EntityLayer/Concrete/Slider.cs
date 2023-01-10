using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }
        public string SliderBaslik { get; set; }
        public string SliderAltBaslik { get; set; }
        public string SliderImage { get; set; }
    }
}
