using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using PokeDex.Contracts.Services;
using PokeDex.Contracts.Models;

namespace PokeDex.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("all", Name = "GetAllPokemon")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _pokemonService.GetAllAsync());
        }

        [HttpPost(Name = "CreatePokemon")]
        public async Task<IActionResult> Create([FromBody] Pokemon pokemon)
        {
            return Ok(await _pokemonService.Create(pokemon));
        }
    }
}
