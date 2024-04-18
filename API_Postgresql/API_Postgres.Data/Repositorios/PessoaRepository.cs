using API_Postgres.Business.Interfaces.Repositorios;
using API_Postgres.Business.Models;
using API_Postgres.Data.Contexto;

namespace API_Postgres.Data.Repositorios
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(APIContext context) : base(context)
        {
        }
    }
}
