using Microsoft.AspNetCore.Http;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class BelgelerDüzenle
    {
        public int BelgeID { get; set; }
        public string BelgeImage { get; set; }
        public string BelgeAcilirImage { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
