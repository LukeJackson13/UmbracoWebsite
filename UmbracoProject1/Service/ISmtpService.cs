using UmbracoProject1.Models;

namespace UmbracoProject1.Services
{
    public interface ISmtpService
    {
        void SendEmail(ContactFormViewModel model);
    }

}
