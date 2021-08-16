using NETCoreNLayer.Core.Models;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
