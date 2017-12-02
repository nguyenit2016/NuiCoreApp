using NuiCoreApp.Data.Entities;
using NuiCoreApp.Infrastructure.Interfaces;

namespace NuiCoreApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
    }
}