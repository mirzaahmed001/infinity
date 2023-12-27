using MySimit.Admin.Application.Interface;
using MySimit.Domain.Entities;
using MySimit.Infrastructure.Interface;

namespace MySimit.Infrastructure.UnitOfWork
{
    public  class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            // Rollback changes if needed
        }

        public IRepository<Country> CountryRepository => new Repository<Country>(_context);
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
