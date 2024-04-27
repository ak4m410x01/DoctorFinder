#region Using Directive Namespaces

using DoctorFinder.Presentation.Extensions.Swagger.Options;

#endregion


namespace DoctorFinder.Presentation.Extensions.Swagger.ServiceCollection
{
    public static class SwaggerGenServiceCollection
    {
        public static IServiceCollection AddSwaggerGenOptions(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.AddSwaggerDocOptions()
                       .AddSecurityDefinitionOptions()
                       .AddSecurityRequirementOptions();
            });
            return services;
        }
    }
}
