using PokeDex.Contracts.Exceptions;
using PokeDex.Contracts.Models;
using PokeDex.Contracts.Repositories;
using PokeDex.Contracts.Services;

namespace PokeDex.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IUnitOfWork _uow;

        public PokemonService(IUnitOfWork uow)
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
                throw new EntityAlreadyExistsException("There is no pokemon with that id.");
            }

            return pokemon;
        }
    }
}
