using AutenticacaoMultifator.Data.Repositories.Base.SQL;
using AutenticacaoMultifator.Domain.Validation;

namespace AutenticacaoMultifator.Application.Services.Colaborador
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly ISQLBaseRepository _colaboradorRepository;

        public ColaboradorService(ISQLBaseRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public IEnumerable<Domain.Entidades.Colaborador> ListarColaboradores()
        {
            var colaboradores = _colaboradorRepository.Listar<Domain.Entidades.Colaborador>();

            if (!colaboradores.Any()) 
                throw new ExceptionValidacao("Não há colaboradores cadastrados no momento.");

            return colaboradores.OrderBy(c => c.Nome);
        }

        public Domain.Entidades.Colaborador ObterColaboradorPorCodigo(Guid codigo)
        {
            var colaborador = _colaboradorRepository.ObterPorCodigo<Domain.Entidades.Colaborador>(c => c.Codigo == codigo) ?? throw new ExceptionValidacao("Não há registros do colaborador.");
            return colaborador;
        }
    }
}