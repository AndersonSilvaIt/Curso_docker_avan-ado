using Microsoft.EntityFrameworkCore;
using TesteDocker_Business.Interfaces;
using TesteDocker_Business;

namespace TesteDocker_Data.Repositorios
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private readonly Contexto _context;
        private readonly DbSet<T> DbSet;

        public Repository(Contexto context)
        {
            _context = context;
            DbSet = context.Set<T>();
        }

        public async Task<T> ObterPorId(int id)
        {
            return await DbSet.AsNoTracking()
                              .Where(x => x.Id == id)
                              .FirstOrDefaultAsync();
        }

        public async Task<IList<T>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<bool> Remover(int id)
        {
            try
            {
                var entity = new T { Id = id };
                DbSet.Remove(entity);

                await SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public async Task<T> Salvar(T entity)
        {
            DbSet.Add(entity);

            await SaveChanges();
            return entity;
        }

        public async Task<bool> Update(T entity)
        {
            DbSet.Update(entity);

            return await SaveChanges() > 0;
        }

        private async Task<int> SaveChanges()
        {
            int qtd = 0;
            try
            {
                qtd = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

            }

            return qtd;
        }
    }
}
