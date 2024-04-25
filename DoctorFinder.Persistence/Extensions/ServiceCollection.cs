using DoctorFinder.Domain.Identity;
using DoctorFinder.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
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

            return services;
        }

        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            // Identity Configuration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            return services;
        }
    }
}
