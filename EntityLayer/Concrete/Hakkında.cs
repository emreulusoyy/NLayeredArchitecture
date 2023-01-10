using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EntityLayer.Concrete
{
    public class Hakkında
    {
        [Key]
        public int HakkındaID { get; set; }
        public string HakkındaBaslik { get; set; }
        public string HakkındaAcıklama { get; set; }
        public string HakkındaImage { get; set; }
    }
}
