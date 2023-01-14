using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class HakkimdaDüzenle
    {
        public int HakkındaID { get; set; }
        public string HakkındaBaslik { get; set; }
        public string HakkındaAcıklama { get; set; }
        public string HakkındaImage { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
