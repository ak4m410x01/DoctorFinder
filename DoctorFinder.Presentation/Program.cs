#region Using Directive Namespaces

using DoctorFinder.Application.Extensions;
using DoctorFinder.Infrastructure.Extensions;
using DoctorFinder.Persistence.Extensions;
using DoctorFinder.Presentation.Extensions.Swagger;

#endregion

namespace DoctorFinder.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Create Web Application Builder

            WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

            #endregion

            // Add services to the container.

            #region Clean Architecture Layers Configuration

            builder.Services.AddApplication()
                            .AddInfrastructure()
                            .AddPersistence(builder.Configuration);

            #endregion

            builder.Services.AddControllers();

            #region Configuring Swagger/OpenAPI

            builder.Services.AddSwagger();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #endregion

            #region Create Web Application

            WebApplication? app = builder.Build();

            #endregion

            #region Config Swagger/OpenAPI Pipeline

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            #endregion

            #region Config Authentication & Authorization Pipelines

            app.UseAuthorization();

            #endregion

            app.MapControllers();

            #region Run Web Application

            app.Run();

            #endregion
        }
    }
}
