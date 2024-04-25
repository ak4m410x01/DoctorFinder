
using DoctorFinder.Domain.Identity;
using DoctorFinder.Persistence.Contexts;
using DoctorFinder.Persistence.Extensions;
using Microsoft.AspNetCore.Identity;

namespace DoctorFinder.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Clean Architecture Layers Configuration
            builder.Services.AddPersistence(builder.Configuration);


            // => TODO: Remove this Configuration and Use Persistence Layer
            // Identity Configuration
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                            .AddEntityFrameworkStores<ApplicationDbContext>()
                            .AddDefaultTokenProviders();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
