using PokeDex.Contracts.Models;
using PokeDex.Contracts.Repositories;
using PokeDex.Contracts.Services;

namespace PokeDex.Services
{
    public class BookService : IPokemonService
    {
        private readonly IUnitOfWork _uow;

        public BookService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<List<Pokemon>> GetAllAsync()
        {
            return await _uow.Pokemon.GetAllAsync();
        }

        public async Task<Pokemon?> GetAsync(int pokemonId)
        {
            Pokemon pokemon = await _uow.Pokemon.GetAsync(pokemonId);
            if (pokemon == null)
            {
                throw new NullReferenceException("There is no pokemon with that id.");
            }

            return pokemon;
        }
    }
}
