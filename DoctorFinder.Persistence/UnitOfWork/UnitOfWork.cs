#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.Repositories.Entities.Medical;
using DoctorFinder.Application.Contracts.Interfaces.UnitOfWork;
using DoctorFinder.Persistence.Contexts;

#endregion


namespace DoctorFinder.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructors
        public UnitOfWork(ApplicationDbContext context, ISpecializationRepository specializations)
        {
            _context = context;
            Specializations = specializations;
        }
        #endregion

        #region Properties
        private ApplicationDbContext _context;

        #region Entities
        private ISpecializationRepository Specializations;
        #endregion

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
