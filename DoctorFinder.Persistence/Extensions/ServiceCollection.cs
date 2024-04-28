#region Using Directive Namespaces

using DoctorFinder.Persistence.Extensions.Contexts;
using DoctorFinder.Persistence.Extensions.Identity;
using DoctorFinder.Persistence.Extensions.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

#endregion


namespace DoctorFinder.Persistence.Extensions
{
    public static class ServiceCollection
    {
        #region AddPersistence

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext(configuration)
                    .AddIdentity()
                    .AddUnitOfWork();

            return services;
        }

        #endregion
    }
}
