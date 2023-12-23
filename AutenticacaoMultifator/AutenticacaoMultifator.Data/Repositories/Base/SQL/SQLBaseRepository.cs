using AutenticacaoMultifator.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AutenticacaoMultifator.Data.Repositories.Base.SQL
{
    public class SQLBaseRepository : ISQLBaseRepository
    {
        private readonly SQLServer _context;
        public SQLBaseRepository(SQLServer context)
        {
            _context = context;
        }


        public IEnumerable<T> Listar<T>() where T : class
        {
           return _context.Set<T>().AsNoTracking().ToList();
        }

        public T? ObterPorCodigo<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return _context.Set<T>().AsNoTracking().SingleOrDefault(predicate);
        }

        public void Inserir<T>(T entidade) where T : class
        {
            _context.Set<T>().Add(entidade);
        }

        public void Atualizar<T>(T entidade) where T : class
        {
            _context.Entry(entidade).State = EntityState.Modified;
            _context.Set<T>().Update(entidade);
        }
    }
}