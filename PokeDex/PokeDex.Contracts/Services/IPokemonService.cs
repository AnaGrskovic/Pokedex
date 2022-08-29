using PokeDex.Contracts.Models;

namespace PokeDex.Contracts.Services
{
    public interface IPokemonService
    {
        Task<List<Pokemon>> GetAllAsync();
        Task<Pokemon?> GetAsync(int pokemonId);
    }
}