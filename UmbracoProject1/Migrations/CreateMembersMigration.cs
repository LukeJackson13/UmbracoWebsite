using Umbraco.Cms.Infrastructure.Migrations;
using UmbracoProject1.Models;

namespace UmbracoProject1.Migrations
{
    public class CreateMembersMigration : MigrationBase
    {
        public CreateMembersMigration(IMigrationContext context) : base(context) { }

        protected override void Migrate()
        {
            if (!TableExists("Members"))
            {
                Create.Table<Member>().Do();
            }
        }
    }
}
