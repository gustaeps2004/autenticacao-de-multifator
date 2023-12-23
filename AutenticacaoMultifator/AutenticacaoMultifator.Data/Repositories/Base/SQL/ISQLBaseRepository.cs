using System.Linq.Expressions;

namespace AutenticacaoMultifator.Data.Repositories.Base.SQL
{
    public interface ISQLBaseRepository
    {
        IEnumerable<T> Listar<T>() where T : class;
        T? ObterPorCodigo<T>(Expression<Func<T, bool>> predicate) where T : class;
        void Inserir<T>(T entidade) where T : class;
        void Atualizar<T>(T entidade) where T : class;
    }
}