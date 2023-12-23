using AutenticacaoMultifator.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AutenticacaoMultifator.Data.Context
{
    public class SQLServer : DbContext
    {
        public SQLServer(DbContextOptions<SQLServer> options) : base(options) {  }

        public DbSet<Colaborador> Colaborador { get; set; }
    }
}
