using NuiCoreApp.Infrastructure.Interfaces;

namespace NuiCoreApp.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}