using NuiCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using NuiCoreApp.Data.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace NuiCoreApp.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
