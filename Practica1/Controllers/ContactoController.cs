using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica1.Controllers
{
    public class ContactoController : Controller
    {
        //
        // GET: /Contacto/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult enviarCorreo()
        {
            var name = Request["name"];
            var email = Request["email"];
            var message = Request["message"];

            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                mail.From = new System.Net.Mail.MailAddress(email, name, System.Text.Encoding.UTF8);
                mail.Subject = "Sitio ASP";
                mail.Body = "Recibió un mensaje de: " +name+" <"+email+">\n\nMensaje:\n" +message;
                mail.To.Add("lilianaguerrero615@gmail.com");

                SmtpServer.Port = 587; 
                SmtpServer.Credentials = new System.Net.NetworkCredential("lilianaguerrero615@gmail.com", "MOLINA23");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
            return View();
        }
    }
}
