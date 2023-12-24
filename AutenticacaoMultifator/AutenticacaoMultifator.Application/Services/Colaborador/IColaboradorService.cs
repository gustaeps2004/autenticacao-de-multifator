namespace AutenticacaoMultifator.Application.Services.Colaborador
{
    public interface IColaboradorService
    {
        IEnumerable<Domain.Entidades.Colaborador> ListarColaboradores();
        Domain.Entidades.Colaborador ObterColaboradorPorCodigo(Guid codigo);
    }
}