#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.Repositories.Entities.Medical;
using DoctorFinder.Domain.Entities.Medical;
using DoctorFinder.Persistence.Contexts;
using DoctorFinder.Persistence.Repositories.Base;

#endregion


namespace DoctorFinder.Persistence.Repositories.Entities.Medical
{
    public class SpecializationRepository : BaseRepository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
