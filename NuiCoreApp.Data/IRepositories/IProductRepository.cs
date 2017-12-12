using NuiCoreApp.Data.Entities;
using NuiCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuiCoreApp.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
