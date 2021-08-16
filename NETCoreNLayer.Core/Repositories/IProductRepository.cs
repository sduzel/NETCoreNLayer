using NETCoreNLayer.Core.Models;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
