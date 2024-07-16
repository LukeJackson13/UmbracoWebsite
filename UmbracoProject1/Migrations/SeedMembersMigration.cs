using Umbraco.Cms.Infrastructure.Migrations;
using UmbracoProject1.Models;

namespace UmbracoProject1.Migrations
{
    public class SeedMembersMigration : MigrationBase
    {
        public SeedMembersMigration(IMigrationContext context) : base(context) { }

        protected override void Migrate()
        {
            var members = new[]
            {
                new Member { FullName = "Alan Easter", FirstName = "Alan", LastName = "Easter", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Associate" },
                new Member { FullName = "Alexadria Robson", FirstName = "Alexadria", LastName = "Robson", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" },
                new Member { FullName = "Arkom Support", FirstName = "Arkom", LastName = "Support", Email = "support@arkom.co.uk", MobilePhone = "08443750742", MembershipType = "First Year Consultant" },
                new Member { FullName = "Aronas Hull", FirstName = "Aronas", LastName = "Hull", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Brendan Spooner", FirstName = "Brendan", LastName = "Spooner", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Cassandra Hough", FirstName = "Cassandra", LastName = "Hough", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" },
                new Member { FullName = "Dan Davidson", FirstName = "Dan", LastName = "Davidson", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" },
                new Member { FullName = "Danika Horner", FirstName = "Danika", LastName = "Horner", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Davey Jones", FirstName = "Davey", LastName = "Jones", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" },
                new Member { FullName = "David Smith", FirstName = "David", LastName = "Smith", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Emre Hurst", FirstName = "Emre", LastName = "Hurst", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Eric Viking", FirstName = "Eric", LastName = "Viking", Email = "alan.easter@arkom.co.uk", MobilePhone = "12345", MembershipType = "First Year Consultant" },
                new Member { FullName = "Haniya Burns", FirstName = "Haniya", LastName = "Burns", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Jamie Milner", FirstName = "Jamie", LastName = "Milner", Email = "alan.easter@arkom.co.uk", MobilePhone = "07539911168", MembershipType = "Consultant" },
                new Member { FullName = "Jamie Milner", FirstName = "Jamie", LastName = "Milner", Email = "alan.easter@arkom.co.uk", MobilePhone = "07539911168", MembershipType = "Student" },
                new Member { FullName = "Jamie Milner", FirstName = "Jamie", LastName = "Milner", Email = "alan.easter@arkom.co.uk", MobilePhone = "07539911168", MembershipType = "Student" },
                new Member { FullName = "Jim Davidson", FirstName = "Jim", LastName = "Davidson", Email = "alan.easter@arkom.co.uk", MobilePhone = "07813350653", MembershipType = "Associate" },
                new Member { FullName = "Kia Hume", FirstName = "Kia", LastName = "Hume", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Kirk Howarth", FirstName = "Kirk", LastName = "Howarth", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Laila Bray", FirstName = "Laila", LastName = "Bray", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "Lincoln Povey", FirstName = "Lincoln", LastName = "Povey", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Consultant" },
                new Member { FullName = "March User", FirstName = "March", LastName = "User", Email = "alan.easter@arkom.co.uk", MobilePhone = "08443750742", MembershipType = "Student" },
                new Member { FullName = "Mary Davidson", FirstName = "Mary", LastName = "Davidson", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Associate" },
                new Member { FullName = "Molly Willsi", FirstName = "Molly", LastName = "Willsi", Email = "molly.willis@arkom.co.uk", MobilePhone = "01142823444", MembershipType = "Student" },
                new Member { FullName = "Penelopy Pitstop", FirstName = "Penelopy", LastName = "Pitstop", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Associate" },
                new Member { FullName = "Peter Perfect", FirstName = "Peter", LastName = "Perfect", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Student" },
                new Member { FullName = "Peter Smith", FirstName = "Peter", LastName = "Smith", Email = "alan.easter@arkom.co.uk", MobilePhone = "012345678", MembershipType = "Associate" },
                new Member { FullName = "Priyanka Farrow", FirstName = "Priyanka", LastName = "Farrow", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" },
                new Member { FullName = "Reuben Howarth", FirstName = "Reuben", LastName = "Howarth", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Student" },
                new Member { FullName = "Ryan Smith", FirstName = "Ryan", LastName = "Smith", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "Associate" },
                new Member { FullName = "Scarlette Sexton", FirstName = "Scarlette", LastName = "Sexton", Email = "alan.easter@arkom.co.uk", MobilePhone = "0123456789", MembershipType = "First Year Consultant" }
            };

            using (var transaction = Database.GetTransaction())
            {
                try
                {
                    foreach (var member in members)
                    {
                        Database.Insert(member);
                    }
                    transaction.Complete();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
