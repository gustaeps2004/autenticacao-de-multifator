using AutenticacaoMultifator.Application.Services.Colaborador;
using AutenticacaoMultifator.Data.Repositories.Base.SQL;
using Microsoft.Extensions.DependencyInjection;

namespace AutenticacaoMultifator.Infrastructure
{
    public static class ConfiguracaoDI
    {
        public static IServiceCollection InjecoesDeDependencia(this IServiceCollection services)
        {
            //Repositórios
            services.AddTransient<ISQLBaseRepository, SQLBaseRepository>();

            //Serviços
            services.AddTransient<IColaboradorService, ColaboradorService>();

            return services;
        }
    }
}