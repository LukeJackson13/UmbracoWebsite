using Umbraco.Cms.Infrastructure.Scoping;
using NPoco;
using Umbraco.Cms.Core.Models;

namespace UmbracoProject1.Services
{
    public class MemberService
    {
        private readonly IScopeProvider _scopeProvider;

        public MemberService(IScopeProvider scopeProvider)
        {
            _scopeProvider = scopeProvider;
        }

        public List<Models.Member> GetAllMembers()
        {
            using (var scope = _scopeProvider.CreateScope(autoComplete: true))
            {
                var sql = Sql.Builder.Select("*").From("Members");
                var members = scope.Database.Fetch<Models.Member>(sql);

                return members;
            }
        }

        public void DeleteMember(int id)
        {
            using (var scope = _scopeProvider.CreateScope())
            {
                var sql = Sql.Builder.Append("DELETE FROM Members WHERE Id = @0", id);
                scope.Database.Execute(sql);
                scope.Complete();
            }
        }

        public void CreateMember(Models.Member model)
        {
            using (var scope = _scopeProvider.CreateScope())
            {
                scope.Database.Insert("Members","Id",true,model);
                scope.Complete();
            }
        }

        public void UpdateMember(Models.Member member)
        {
            using (var scope = _scopeProvider.CreateScope())
            {
                scope.Database.Update(member);
                scope.Complete();
            }
        }

        public Models.Member GetMemberById(int id)
        {
            using (var scope = _scopeProvider.CreateScope())
            {
                var sql = Sql.Builder.Append("SELECT * FROM Members WHERE Id = @0", id);
                var member = scope.Database.SingleOrDefault<Models.Member>(sql);
                return member;
            }
        }
    }
}
