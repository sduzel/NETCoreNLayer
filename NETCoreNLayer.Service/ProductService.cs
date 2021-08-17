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
            await _unitOfWork.Products.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<Product>> AddRangeAsync(IEnumerable<Product> entities)
        {
            await _unitOfWork.Products.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public Task<IEnumerable<Product>> Where(Expression<Func<Product, bool>> predicate)
        {
            return _unitOfWork.Products.Where(predicate);
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            return _unitOfWork.Products.GetAllAsync();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return _unitOfWork.Products.GetByIdAsync(id);
        }

        public Task<Product> GetWithCategoryByIdAsync(int categoryId)
        {
            return _unitOfWork.Products.GetWithCategoryByIdAsync(categoryId);
        }

        public void Remove(Product entity)
        {
            _unitOfWork.Products.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<Product> entity)
        {
            _unitOfWork.Products.RemoveRange(entity);
            _unitOfWork.Commit();
        }

        public Task<Product> SingleOrDefault(Expression<Func<Product, bool>> predicate)
        {
            return _unitOfWork.Products.SingleOrDefault(predicate);
        }

        public Product Update(Product entity)
        {
            _unitOfWork.Products.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }
    }
}
