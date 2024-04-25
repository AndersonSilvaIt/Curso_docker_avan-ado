
using API_Postgres_Business.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Postgres_Data.Contexto
{
    public class APIContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            
        }

    }
}
