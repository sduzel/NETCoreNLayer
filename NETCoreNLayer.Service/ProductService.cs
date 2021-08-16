using NETCoreNLayer.Core.Models;
using NETCoreNLayer.Core.Services;
using NETCoreNLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NETCoreNLayer.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Product> AddAsync(Product entity)
        {
            return await _unitOfWork.Products.AddAsync(entity);
        }

        public Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> FindAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetWithCategoryByIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Product Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product RemoveRange(IEnumerable<Product> entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> SingleOrDefault(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
