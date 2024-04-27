#region Using Directive Namespaces

using DoctorFinder.Domain.Identity;
using DoctorFinder.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

#endregion


namespace DoctorFinder.Persistence.Extensions.Identity
{
    public static class IdentityServiceCollection
    {
        #region AddIdentityConfiguration

        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            // Identity Configuration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            return services;
        }

        #endregion
    }
}
