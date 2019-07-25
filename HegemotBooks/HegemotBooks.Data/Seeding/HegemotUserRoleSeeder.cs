using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using HegemotBooks.Domain;

namespace HegemotBooks.Data.Seeding
{
    public class HegemotUserRoleSeeder : ISeeder
    {
        private readonly HegemotBooksDbContext context;

        public HegemotUserRoleSeeder(HegemotBooksDbContext context)
        {
            this.context = context;
        }

        public async Task Seed()
        {
            if (!context.Roles.Any())
            {
                context.Roles.Add(new HegemotUserRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });

                context.Roles.Add(new HegemotUserRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                });
            }

            context.SaveChanges();
        }
    }
}