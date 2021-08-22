using Microsoft.EntityFrameworkCore;
using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreNLayer.Data.Repositories
{
    public class OfferRepository : Repository<Offer>, IOfferRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public OfferRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Offer> GetWithProductByIdAsync(int offerId)
        {
            return await appDbContext.Offers.Include(t=>t.Product).FirstOrDefaultAsync(t => t.Id == offerId);
        }

        public async Task<IEnumerable<Offer>> GetAllWithProductAsync()
        {
            return await appDbContext.Offers.Include(t => t.Product).ToListAsync();
        }
    }
}
