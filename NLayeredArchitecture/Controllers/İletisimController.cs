using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Text;
using System;
using Microsoft.AspNetCore.Authorization;

namespace NLayeredArchitecture.Controllers
{
    [AllowAnonymous]
    public class İletisimController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        // [HttpPost, ValidateAntiForgeryToken]
        public ActionResult MailGonder(string name, string email, string phone, string subject, string message)
        {
            try
            {
                var smtpServer = new SmtpClient("mail.proserbilisim.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("yazilim@proserbilisim.com", "Proser@2394455/*-"),
                    EnableSsl = false
                };
                var mail = new MailMessage
                {
                    From = new MailAddress("yazilim@proserbilisim.com", "Proser"),
                    Subject = "Proser" + " - " + "İletişim Formu",
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8,
                    Body = "İletişim Formu<br/><br/>Ad-Soyad : " + name + "<br/>Telefon : " + phone + "<br/>E-Posta Adresi : " + email + "<br/>WebSite : " + subject + "<br/>Mesaj : " + message
                };
                mail.To.Add("yazilim@proserbilisim.com");
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
