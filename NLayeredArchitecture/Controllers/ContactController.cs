using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Text;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace NLayeredArchitecture.Controllers
{
    public class ContactController : Controller
    {
        // [HttpPost, ValidateAntiForgeryToken]
        public ActionResult MailGonder(string name, string email, string phone, string subject, string message)
        {
            try
            {
                var smtpServer = new SmtpClient("mail.tmyangin.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("web@tmyangin.com", "TmYangin2022"),
                    EnableSsl = true
                };
                var mail = new MailMessage
                {
                    From = new MailAddress("web@tmyangin.com", "Tm Yangın Sistemleri"),
                    Subject = "Tm Yangın Sistemleri" + " - " + "İletişim Formu",
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    Body = "İletişim Formu<br/><br/>Ad-Soyad : " + name + "<br/>Telefon : " + phone + "<br/>E-Posta Adresi : " + email + "<br/>WebSite : " + subject + "<br/>Mesaj : " + message
                };
                mail.To.Add("info@tmyangin.com");
                smtpServer.Send(mail);
                smtpServer.Dispose();

                var deger = "Başarılı";
                //session.Add("iletisim", deger);
            }
            catch (Exception ex)
            {
                var deger = "Başarısız";
                //Session.Add("iletisim", deger);
                var a = ex.ToString();
            }

            return Redirect("Index");
        }
    }

  
}

