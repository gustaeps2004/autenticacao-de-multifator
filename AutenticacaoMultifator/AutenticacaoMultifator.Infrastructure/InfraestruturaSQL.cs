using AutenticacaoMultifator.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutenticacaoMultifator.Infrastructure
{
    public static class InfraestruturaSQL
    {
        public static IServiceCollection AdicionarInfraestruturaSQL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SQLServer>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SQL_SERVER"),
                b => b.MigrationsAssembly(typeof(SQLServer).Assembly.FullName)));

            return services;
        }
    }
}