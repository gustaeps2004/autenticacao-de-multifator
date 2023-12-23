using AutenticacaoMultifator.API.Controllers.V1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace AutenticacaoMultifator.Infrastructure
{
    public static class Swagger
    {
        public static IServiceCollection ConfigurarSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "API Version 1",
                    Version = "v1"
                });

                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                options.CustomSchemaIds(x => x.FullName);
            });

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.Conventions.Controller<ColaboradorController>().HasApiVersion(new ApiVersion(1, 0));
            });

            return services;
        }
    }
}
