using NETCoreNLayer.Core.Models;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int categoryId);
    }
}
