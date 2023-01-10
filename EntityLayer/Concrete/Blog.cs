using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string AnaBaslik { get; set; }
        public string AltBaslik { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogTarih { get; set; }
        public string BlogImage { get; set; }
        
    }
}
