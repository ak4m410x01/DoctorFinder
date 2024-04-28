#region Using Directive Namespaces

using DoctorFinder.Application.Contracts.Interfaces.Repositories.Entities.Medical;
using DoctorFinder.Persistence.Repositories.Entities.Medical;
using Microsoft.Extensions.DependencyInjection;

#region

namespace DoctorFinder.Persistence.Extensions.Repositories.Medical
{
    public static class SpecializationServiceCollection
    {
        public static IServiceCollection AddSpecializationRepository(this IServiceCollection services)
        {
            services.AddScoped<ISpecializationRepository, SpecializationRepository>();
            return services;
        }
    }
}
