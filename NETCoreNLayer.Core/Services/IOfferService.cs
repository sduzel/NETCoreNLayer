using NETCoreNLayer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.Services
{
    public interface IOfferService:IService<Offer>
    {
        Task<IEnumerable<Offer>> GetAllWithProductAsync();
        Task<Offer> GetWithProductByIdAsync(int offerId);
    }
}
