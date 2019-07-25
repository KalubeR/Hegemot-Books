using System.Threading.Tasks;

namespace HegemotBooks.Data.Seeding
{
    public interface ISeeder
    {
        Task Seed();
    }
}