using Microsoft.AspNetCore.Mvc;//MVC pattern that contains definitions gor controller actions,views
using UmbracoProject1.Models;
using Umbraco.Cms.Core.Web;// For accessing Umbraco's content and context.
using Umbraco.Cms.Web.Website.Controllers;//For controllers specific to website functionalities in Umbraco.
using UmbracoProject1.Services;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Web.Common.Filters;
using Microsoft.Extensions.Options;
using System.Text.Json;


namespace UmbracoProject1.Areas.MyPlugin.Controllers
{
    public class ContactFormController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider,
        ILogger<ContactFormController> logger,
        ISmtpService smtpService,
        IOptions<GoogleCaptchaConfig> _googleCaptchaConfig) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateUmbracoFormRouteString]
        public IActionResult HandleContactFormSubmission([Bind(Prefix = "contactModel")] ContactFormViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return CurrentUmbracoPage();
            }

            var isValidCaptcha = VerifyRecaptcha(model.RecaptchaToken).GetAwaiter().GetResult();

            if(!isValidCaptcha)
            {
                return CurrentUmbracoPage();
            }

            smtpService.SendEmail(model);

            TempData["FormSuccess"] = true;

            return RedirectToCurrentUmbracoPage();
        }

        private async Task<bool> VerifyRecaptcha(string token)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={_googleCaptchaConfig.Value.SecretKey}&response={token}");
                if (response.IsSuccessStatusCode)
                {
                    var googleCaptchResponse = await JsonSerializer.DeserializeAsync<GoogleCaptchaResponse>(await response.Content.ReadAsStreamAsync());
                    if (!googleCaptchResponse.Success)
                    {
                        return false;
                    }

                    return googleCaptchResponse.Score > 0.5;
                }

                return false;
            }
        }
    }
}


