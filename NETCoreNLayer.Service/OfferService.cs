using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Repositories;
using NETCoreNLayer.Core.Services;
using NETCoreNLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NETCoreNLayer.Service
{
    public class OfferService : Service<Offer>, IOfferService
    {
        public OfferService(IUnitOfWork unitOfWork, IRepository<Offer> repository) : base(unitOfWork, repository)
        {
        }
        public async Task<IEnumerable<Offer>> GetAllWithProductAsync()
        {
            return await _unitOfWork.Offers.GetAllWithProductAsync();
        }

        public async Task<Offer> GetWithProductByIdAsync(int offerId)
        {
            return await _unitOfWork.Offers.GetWithProductByIdAsync(offerId);
        }
    }
}
