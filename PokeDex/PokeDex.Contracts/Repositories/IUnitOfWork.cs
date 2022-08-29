using PokeDex.Contracts.Models;
using PokeDex.Contracts.Repositories.Base;

namespace PokeDex.Contracts.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<Pokemon> Pokemon { get; }
        Task SaveChangesAsync();
    }
}
