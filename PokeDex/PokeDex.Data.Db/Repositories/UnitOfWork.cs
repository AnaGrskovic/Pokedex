using PokeDex.Contracts.Models;
using PokeDex.Contracts.Repositories;
using PokeDex.Contracts.Repositories.Base;
using PokeDex.Data.Db.Configurations;
using PokeDex.Data.Db.Repositories.Base;

namespace PokeDex.Data.Db.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepository<Pokemon> _pokemon;

        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IRepository<Pokemon> Pokemon
            => _pokemon ?? new Repository<Pokemon>(_dbContext);

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}