using TesteDocker_Business.Interfaces;
using TesteDocker_Business;

namespace TesteDocker_Data.Repositorios
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(Contexto context) : base(context)
        {
        }
    }
}
