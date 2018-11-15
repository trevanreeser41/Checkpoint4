using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            
            return "Please call Support at <u><strong>801-555-1212</strong></u>. Thank you!";
        }
        public string Email(string name, string email)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(email));  // replace with valid value 
            message.From = new MailAddress("testingbyumvc@gmail.com");  // replace with valid value
            message.Subject = "Confirmation of Contact";
            message.Body = name + ", thank you for your concern!";
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "testingbyumvc@gmail.com",  // replace with valid value
                    Password = "Idahome1"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);

                return "Thank you " + name + "! We will send you an email to " + email + "!";
            }
        }
    }
}