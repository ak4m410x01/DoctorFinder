#region Using Directive Namespaces

using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

#endregion


namespace DoctorFinder.Presentation.Extensions.Swagger.Options
{
    public static class SwaggerDocOptions
    {
        public static SwaggerGenOptions AddSwaggerDocOptions(this SwaggerGenOptions swagger)
        {
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Doctor Finder API",
                Version = "v1",
                Description = "Doctor Finder connects patients and doctors for seamless appointments. Patients search for doctors by specialty and location. Availability is based on the doctor's work schedule, ensuring appointments during working hours. Book appointments, manage them easily, and pay online or offline - all within this secure platform.",

                License = new OpenApiLicense
                {
                    Name = "GNU General Public License v3.0",
                    Url = new Uri("https://github.com/ak4m410x01/DoctorFinder/blob/develop/LICENSE")
                },
                Contact = new OpenApiContact
                {
                    Name = "Abdullah Kamal",
                    Email = "abdullah.kamal0x01@gmail.com",
                    Url = new Uri("https://ak4m410x01.vercel.app")
                },
            });

            return swagger;
        }
    }
}
