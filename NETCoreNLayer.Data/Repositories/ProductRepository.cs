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
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
           return await appDbContext.Products.Include("Category").FirstOrDefaultAsync(t => t.Id == productId);
        }
    }
}
