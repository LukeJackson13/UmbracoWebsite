using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Migrations;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Migrations.Upgrade;
using UmbracoProject1.Migrations;

namespace UmbracoProject1.Components
{
    public class MembersComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddUnique<IMigrationPlanExecutor, MigrationPlanExecutor>();
            builder.Services.AddUnique<MigrationPlan, MembersMigrationPlan>();
            builder.Components().Append<MembersComponent>();
        }
    }

    public class MembersMigrationPlan : MigrationPlan
    {
        public MembersMigrationPlan() : base("Members")
        {
            From(string.Empty)
                .To<CreateMembersMigration>("create members table")
                .To<SeedMembersMigration>("seed-members-table-data");
        }
    }

    public class MembersComponent : IComponent
    {
        private readonly ICoreScopeProvider _scopeProvider;
        private readonly IMigrationPlanExecutor _migrationPlanExecutor;
        private readonly IKeyValueService _keyValueService;

        public MembersComponent(ICoreScopeProvider scopeProvider, IMigrationPlanExecutor migrationPlanExecutor, IKeyValueService keyValueService)
        {
            _scopeProvider = scopeProvider;
            _migrationPlanExecutor = migrationPlanExecutor;
            _keyValueService = keyValueService;
        }

        public void Initialize()
        {
            var upgrader = new Upgrader(new MembersMigrationPlan());
            upgrader.Execute(_migrationPlanExecutor, _scopeProvider, _keyValueService);
        }

        public void Terminate()
        {
        }
    }
}
