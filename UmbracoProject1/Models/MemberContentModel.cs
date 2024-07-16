using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject1.Models
{
    public class MemberContentModel : ContentModel
    {

        public MemberContentModel(IPublishedContent content) : base(content) 
        { 
        
        }
        
        public List<Member> Members { get; set; }

        public Member? MemberBeingEdited { get; set; }


    }
}
