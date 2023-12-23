using Microsoft.EntityFrameworkCore;

namespace AutenticacaoMultifator.Data.Context
{
    public class SQLServer : DbContext
    {
        public SQLServer(DbContextOptions<SQLServer> options) : base(options) {  }
    }
}
