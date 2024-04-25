using Microsoft.Extensions.DependencyInjection;

namespace DoctorFinder.Application.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add Application Services here...


            return services;
        }
    }
}
