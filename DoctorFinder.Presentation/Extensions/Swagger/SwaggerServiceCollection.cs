#region Using Directive Namespaces

using DoctorFinder.Presentation.Extensions.Swagger.ServiceCollection;

#endregion


namespace DoctorFinder.Presentation.Extensions.Swagger
{
    public static class SwaggerServiceCollection
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGenOptions();

            return services;
        }
    }
}
