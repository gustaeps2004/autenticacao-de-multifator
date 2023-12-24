using AutenticacaoMultifator.Application.DTOs;

namespace AutenticacaoMultifator.Application.Services.Autenticacao
{
    public interface IAutenticacaoService
    {
        Task<Domain.Entidades.Colaborador> Login(AutenticacaoLoginDTO autenticacaoDTO);
    }
}