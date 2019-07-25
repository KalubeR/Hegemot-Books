using System.Threading.Tasks;
using HegemotBooks.Domain;
using Microsoft.AspNetCore.Identity;

namespace HegemotBooks.Data.Seeding
{
    public class HegemotAdminUserSeeder : ISeeder
    {
        private readonly UserManager<HegemotBooksUser> userManager;

        public HegemotAdminUserSeeder(UserManager<HegemotBooksUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task Seed()
        {
            var user = new HegemotBooksUser
            {
                UserName = "root",
                Email = "root@eventures.com",
                FullName = "Root"
            };

            var result = await this.userManager.CreateAsync(user, "root");
        }
    }
}