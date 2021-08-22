using NETCoreNLayer.Core.Repositories;
using NETCoreNLayer.Core.UnitOfWorks;
using NETCoreNLayer.Data.Repositories;
using System.Threading.Tasks;

namespace NETCoreNLayer.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private OfferRepository _offerRepository;
        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IOfferRepository Offers => _offerRepository = _offerRepository ?? new OfferRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
