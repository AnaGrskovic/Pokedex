using PokeDex.Contracts.Repositories.Base;
using PokeDex.Data.Db.Configurations;
using Microsoft.EntityFrameworkCore;

namespace PokeDex.Data.Db.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entity;

        public Repository(ApplicationDbContext dbContext)
        {
            _entity = dbContext.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public async Task<TEntity?> GetAsync(int id)
        {
            return await _entity.FindAsync(id);
        }

        public void Add(TEntity entity)
        {
            _entity.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);
        }
    }
}
