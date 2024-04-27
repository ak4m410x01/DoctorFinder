#region Using Directive Namespaces

using DoctorFinder.Presentation.Extensions.Swagger.Options;

#endregion


namespace DoctorFinder.Presentation.Extensions.Swagger.ServiceCollection
{
    public static class SwaggerGenServiceCollection
    {
        public static IServiceCollection AddSwaggerGenOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.AddSwaggerDocOptions(configuration)
                       .AddSecurityDefinitionOptions()
                       .AddSecurityRequirementOptions();
            });
            return services;
        }
    }
}
