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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int categoryId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(categoryId);
        }
    }
}
