using System.ComponentModel.DataAnnotations;

namespace NLayeredArchitecture.Areas.Admin.Models
{
    public class AdminKayitPaneli

    {
        [Required(ErrorMessage = "Lütfen Adınızı giriniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz")]
        public string Soyad { get; set; }


        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı Adını giriniz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string PassWord { get; set; }


        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        [Compare("PassWord", ErrorMessage = "Şifreler birbirleriyle eşleşmiyor!")]
        public string ConfirmPassWord { get; set; }


        
    }
}
