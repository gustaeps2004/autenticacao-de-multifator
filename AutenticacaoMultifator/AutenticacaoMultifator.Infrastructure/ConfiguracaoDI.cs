using AutenticacaoMultifator.Data.Repositories.Base.SQL;
using Microsoft.Extensions.DependencyInjection;

namespace AutenticacaoMultifator.Infrastructure
{
    public static class ConfiguracaoDI
    {
        public static IServiceCollection InjecoesDeDependencia(this IServiceCollection services)
        {
            services.AddTransient<ISQLBaseRepository, SQLBaseRepository>();

            return services;
        }
    }
}
