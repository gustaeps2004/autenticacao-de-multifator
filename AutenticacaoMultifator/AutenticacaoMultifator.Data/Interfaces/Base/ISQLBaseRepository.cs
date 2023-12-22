using System.Linq.Expressions;

namespace AutenticacaoMultifator.Data.Interfaces.Base
{
	public interface ISQLBaseRepository
	{
		IEnumerable<T> ObterTudo<T>(int top, int offset) where T : class;
		T ObterPorCodigo<T>(Expression<Func<T, bool>> predicate) where T : class;
		void Inserir<T>(T entidade) where T : class;
		void Atualizar<T>(T entidade) where T : class;
		IEnumerable<T> RawQuery<T>(string sql, object parametros = null) where T : class;
	}
}