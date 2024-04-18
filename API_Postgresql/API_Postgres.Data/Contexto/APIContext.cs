using API_Postgres.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Postgres.Data.Contexto
{
    public class APIContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            
        }

    }
}
