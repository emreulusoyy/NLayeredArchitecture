using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Belgeler
    {
        [Key]
        public int BelgeID { get; set; }
        public string BelgeBaslik { get; set; }
        public string BelgeImage { get; set; }
        public string BelgeAcilirImage { get; set; }
    }
}
