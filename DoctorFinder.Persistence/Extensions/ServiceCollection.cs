using DoctorFinder.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorFinder.Persistence.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext(configuration);

            return services;
        }
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Get Connection String From appsettings.json
            string? connectionString = configuration.GetConnectionString("LocalDevelopmentDbConnection");

            // Add Application Db Context
            services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlServer(connectionString, builder =>
                                builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            // Identity Configuration
            //services.AddIdentityCore<ApplicationUser, IdentityRole>()
            //        .AddEntityFrameworkStores<ApplicationDbContext>()
            //        .AddDefaultTokenProviders();

            return services;
        }
    }
}
