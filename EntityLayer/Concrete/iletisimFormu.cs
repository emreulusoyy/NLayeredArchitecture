using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class iletisimFormu
    {
        [Key]
        public int İletişimID { get; set; }
        public string SahısFirmaAdi { get; set; }
        public string Email { get; set; }
        public string Konu { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}
