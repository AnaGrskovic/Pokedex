using PokeDex.Contracts.DTOs.Security;
using PokeDex.Contracts.Models.Security;
using PokeDex.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PokeDex.API.Controllers
{
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("api/pokemon/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            TokenDTO tokenDTO = await _loginService.Login(loginRequest);
            return Ok(tokenDTO);
        }
    }
}
