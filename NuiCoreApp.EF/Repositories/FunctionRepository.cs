using NuiCoreApp.Data.Entities;
using NuiCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuiCoreApp.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {

        }
    }
}
