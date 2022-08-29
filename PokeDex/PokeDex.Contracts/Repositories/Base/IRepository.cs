namespace PokeDex.Contracts.Repositories.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> GetAsync(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
    }
}
