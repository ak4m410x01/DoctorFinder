#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.Repositories.Base;
using DoctorFinder.Domain.Entities.Medical;

#endregion


namespace DoctorFinder.Application.Contracts.Interfaces.Repositories.Entities.Medical
{
    public interface ISpecializationRepository : IBaseRepository<Specialization>
    {
    }
}
