#region Using Directive Namespaces

using Microsoft.Extensions.DependencyInjection;

#endregion


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
