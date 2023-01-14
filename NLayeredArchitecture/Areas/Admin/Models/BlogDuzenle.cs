using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class BlogDuzenle
    {
        public int BlogID { get; set; }
        public string BlogBaslik { get; set; }
        public string BlogTarih { get; set; }
        public string BlogImage { get; set; }
		public string DevaminiOku { get; set; }
		public IFormFile ImageFile { get; set; }
    }
}
