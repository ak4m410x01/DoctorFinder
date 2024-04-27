#region Using Directive Namespaces

using DoctorFinder.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

#endregion


namespace DoctorFinder.Persistence.Extensions.Contexts
{
    public static class DbContextServiceCollection
    {
        #region AddDbContext

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Get Connection String From appsettings.json
            string? connectionString = configuration.GetConnectionString("LocalDevelopmentDbConnection");

            // Add Application Db Context
            services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(connectionString, builder =>
                                builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            return services;
        }

        #endregion
    }
}
