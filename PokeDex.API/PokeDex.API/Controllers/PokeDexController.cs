using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace PokeDex.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/pokemon")]
    public class PokeDexController
    {
        [HttpGet("all", Name = "GetAllPokemon")]
        public IActionResult GetAll()
        {
            return null;
        }
    }
}
