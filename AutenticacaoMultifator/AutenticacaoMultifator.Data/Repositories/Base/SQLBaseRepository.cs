using AutenticacaoMultifator.Data.Interfaces.Base;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace AutenticacaoMultifator.Data.Repositories.Base
{
	public class SQLBaseRepository : ISQLBaseRepository
	{
		private readonly string _stringConexao;

        public SQLBaseRepository(string stringConexao)
        {
			_stringConexao = stringConexao;
        }
        public IEnumerable<T> ObterTudo<T>(int top, int offset) where T : class
		{
			 string sql = @$"SELECT 
								TOP {top} 
								*
							FROM
								{nameof(T)}
							OFFSET
								{offset}";

			using SqlConnection conexao = new SqlConnection(_stringConexao);
		}

		public T ObterPorCodigo<T>(Expression<Func<T, bool>> predicate) where T : class
		{
			throw new NotImplementedException();
		}

		public void Inserir<T>(T entidade) where T : class
		{
			throw new NotImplementedException();
		}

		public void Atualizar<T>(T entidade) where T : class
		{
			throw new NotImplementedException();
		}

		public IEnumerable<T> RawQuery<T>(string sql, object parametros = null) where T : class
		{
			throw new NotImplementedException();
		}
	}
}