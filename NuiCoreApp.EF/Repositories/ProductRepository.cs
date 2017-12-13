﻿using NuiCoreApp.Data.Entities;
using NuiCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuiCoreApp.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
    }
}
