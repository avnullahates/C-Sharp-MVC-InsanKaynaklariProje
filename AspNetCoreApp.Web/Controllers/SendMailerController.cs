using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using AspNetCoreApp.Web.Models;


namespace AspNetCoreApp.Web.Controllers
{
    public class SendMailerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.MailModel model)
        {
            MailMessage mm = new MailMessage("john1996doe1996@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            NetworkCredential nc = new NetworkCredential("john1996doe1996@gmail.com", "saodzpcotcmhunho");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
            

            ViewBag.Message = "Mail Başarıyla Gönderildi!";

            return View();

            //if (ModelState.IsValid)
            //{
            //    MailMessage mail = new MailMessage();
            //    mail.To.Add(_objModelMail.To);
            //    mail.From = new MailAddress(_objModelMail.From);
            //    mail.Subject = _objModelMail.Subject;
            //    string Body = _objModelMail.Body;
            //    mail.Body = Body;
            //    mail.IsBodyHtml = true;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 587;
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Credentials = new System.Net.NetworkCredential("username", "password"); // mail yollayanın username ve passwordu
            //    smtp.EnableSsl = true;
            //    smtp.Send(mail);
            //    return View("Index", _objModelMail);
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
