using Microsoft.EntityFrameworkCore;
using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NETCoreNLayer.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include("Product").SingleOrDefaultAsync(t => t.Id == categoryId);
        }
    }
}
