using AutenticacaoMultifator.Application.DTOs;
using AutenticacaoMultifator.Data.Repositories.Base.SQL;

namespace AutenticacaoMultifator.Application.Services.Autenticacao
{
    public class AutenticacaoService : IAutenticacaoService
    {
        private readonly ISQLBaseRepository _baseRepository;

        public AutenticacaoService(ISQLBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Task<Domain.Entidades.Colaborador> Login(AutenticacaoLoginDTO autenticacaoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
