using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using UmbracoProject1.Models;
using UmbracoProject1.Services;

namespace UmbracoProject1.Controllers
{
    public class MembersController : RenderController
    {
        private readonly MemberService _memberService;

        public MembersController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, MemberService memberService) : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _memberService = memberService;
        }

        public override IActionResult Index()
         {
            var model = BuildMemberContentModel();

            if(int.TryParse(Request.Query["id"], out int id))
            {
                model.MemberBeingEdited = _memberService.GetMemberById(id);
            }

            return CurrentTemplate(model);
        }

        private MemberContentModel BuildMemberContentModel()
        {
            var model = new MemberContentModel(CurrentPage);

            model.Members = _memberService.GetAllMembers();

            return model;
        }

    }
}
