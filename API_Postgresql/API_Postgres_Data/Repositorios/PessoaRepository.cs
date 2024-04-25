using API_Postgres_Business.Interfaces.Repositorios;
using API_Postgres_Business.Models;
using API_Postgres_Data.Contexto;

namespace API_Postgres_Data.Repositorios
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(APIContext context) : base(context)
        {
        }
    }
}
