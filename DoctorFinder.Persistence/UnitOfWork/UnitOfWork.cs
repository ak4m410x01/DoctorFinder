#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.UnitOfWork;
using DoctorFinder.Persistence.Contexts;

#endregion


namespace DoctorFinder.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructors
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Properties
        private ApplicationDbContext _context;
        #endregion

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
