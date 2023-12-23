namespace AutenticacaoMultifator.Application.Services.Colaborador
{
    public interface IColaboradorService
    {
        IEnumerable<Domain.Entidades.Colaborador> ListarColaboradores();
        Domain.Entidades.Colaborador ObterColaboradorPorCodigo(Guid Codigo);
        void InserirColaborador(Domain.Entidades.Colaborador colaborador);
        void AtualizarColaborador(Domain.Entidades.Colaborador colaborador);
    }
}