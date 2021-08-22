using NETCoreNLayer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Repositories
{
    public interface IOfferRepository : IRepository<Offer>
    {
        Task<Offer> GetWithProductByIdAsync(int offerId);
        Task<IEnumerable<Offer>> GetAllWithProductAsync();
    }
}
