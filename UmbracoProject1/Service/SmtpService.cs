using System.Net;
using System.Net.Mail;
using UmbracoProject1.Models;

namespace UmbracoProject1.Services
{
    public class SmtpService : ISmtpService
    {
        public void SendEmail(ContactFormViewModel model)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("SMTP service username", "SMTP service password"),
                EnableSsl = true
            };
            client.Send(model.Email, "to@example.com", model.FirstName + " " + model.LastName, "Phone Number: " + model.Phone  + "\nMessage: "+ model.Message);
        }
    }
}
