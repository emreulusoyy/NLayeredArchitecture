using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class HizmetlerDuzenle
    {
        public int HizmetlerID { get; set; }
        public string HizmetlerBaslik { get; set; }
        public string HizmetlerImage { get; set; }
        public string HizmetlerAcıklama { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
