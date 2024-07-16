using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace UmbracoProject1.Models
{
    [TableName("Members")]
    [PrimaryKey("Id", AutoIncrement = true)]
    [ExplicitColumns]
    public class Member
    {
        [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
        [Column("Id")]
        public int Id { get; set; }

        [NullSetting(NullSetting = NullSettings.NotNull)]
        [Column("Full Name")]
        public string FullName { get; set; }

        [NullSetting(NullSetting = NullSettings.NotNull)]
        [Column("First Name")]
        public string FirstName { get; set; }

        [NullSetting(NullSetting = NullSettings.NotNull)]
        [Column("Last Name")]
        public string LastName { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        [Column("Email")]
        public string Email { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        [Column("Mobile Phone")]
        public string MobilePhone { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        [Column("Membership Type")]
        public string MembershipType { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        public Member()
        {
            CreatedDate = DateTime.UtcNow; // or any default value you prefer
        }
    }
}
