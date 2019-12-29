using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.ORM.EF.ContextoDB
{
    public class Conexao : DbContext
    {
        public Conexao(DbContextOptions<Conexao> options) : base(options)
        {

        }




    }
}
