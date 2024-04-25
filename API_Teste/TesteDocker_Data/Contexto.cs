using Microsoft.EntityFrameworkCore;
using TesteDocker_Business;

namespace TesteDocker_Data
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
