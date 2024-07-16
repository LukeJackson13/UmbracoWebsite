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
using UmbracoProject1.Services;


namespace UmbracoProject1.Controllers
{
    public class MembersSurfaceController : SurfaceController
    {
        private readonly Services.MemberService _memberService;
        public MembersSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, Services.MemberService memberService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteMember(int id)
        {
            _memberService.DeleteMember(id);

            return CurrentUmbracoPage();
        }

        public IActionResult LoadRegisterMemberForm()
        {
            TempData["ShowRegisterMemberForm"] = true;
            return RedirectToCurrentUmbracoPage();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitRegisterMemberForm([Bind(Prefix = "memberModel")] Member model)
        {
            if (ModelState.IsValid)
            {
                _memberService.CreateMember(model);

                return RedirectToCurrentUmbracoPage();
            }

            return PartialView("Partials/RegisterMemberForm", model);
        }

        public IActionResult LoadEditMemberForm(int id)
        {
            return RedirectToCurrentUmbracoPage(QueryString.Create("id",id.ToString()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateMember([Bind(Prefix = "updateModel")] Member member)
        {
            if (ModelState.IsValid)
            {
                _memberService.UpdateMember(member);

                return RedirectToCurrentUmbracoPage();
            }

            return RedirectToCurrentUmbracoPage();
        }

    }
}
