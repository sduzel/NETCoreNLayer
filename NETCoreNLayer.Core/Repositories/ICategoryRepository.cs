using NETCoreNLayer.Core.Models;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
