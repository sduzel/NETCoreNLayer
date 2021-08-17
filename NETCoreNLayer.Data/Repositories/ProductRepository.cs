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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
           return await appDbContext.Products.Include(t=>t.Category).FirstOrDefaultAsync(t => t.Id == productId);
        }
    }
}
