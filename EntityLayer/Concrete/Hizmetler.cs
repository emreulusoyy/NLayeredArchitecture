using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hizmetler
    {
        [Key]
        public int HizmetlerID { get; set; }
        public string HizmetlerBaslik { get; set; }
        public string HizmetlerImage { get; set; }
        public string HizmetlerAcıklama { get; set; }
    }
}
