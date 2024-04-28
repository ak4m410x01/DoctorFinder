namespace DoctorFinder.Application.Contracts.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveAsync();
    }
}
