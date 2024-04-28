#region Using Directive Namespaces

using Microsoft.Extensions.DependencyInjection;
using UnitOfWorkContract = DoctorFinder.Application.Contracts.Interfaces.UnitOfWork;
using UnitOfWorkImplementation = DoctorFinder.Persistence.UnitOfWork;

#endregion


namespace DoctorFinder.Persistence.Extensions.UnitOfWork
{
    public static class UnitOfWorkServiceCollection
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<UnitOfWorkContract.IUnitOfWork, UnitOfWorkImplementation.UnitOfWork>();
            return services;
        }
    }
}
