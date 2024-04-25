using API_Postgres_Business.Models;

namespace API_Postgres_Business.Interfaces.Repositorios
{
    public interface IRepository<T> where T : Entity, new()
    {
        Task<T> Salvar(T entity);
        Task<bool> Update(T entity);
        Task<IList<T>> ObterTodos();
        Task<T> ObterPorId(int id);
        Task<bool> Remover(int Id);
    }
}