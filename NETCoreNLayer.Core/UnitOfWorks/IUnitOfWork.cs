using NETCoreNLayer.Core.Repositories;
using System.Threading.Tasks;

namespace NETCoreNLayer.Core.UnitOfWorks
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
        void Commit();

    }
}
