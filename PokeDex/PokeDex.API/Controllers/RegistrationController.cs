using Microsoft.AspNetCore.Mvc;
using PokeDex.Contracts.Services;
using PokeDex.Contracts.Models.Security;
using Microsoft.AspNetCore.Authorization;

namespace PokeDex.API.Controllers
{
    [AllowAnonymous]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;
        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest registrationRequest)
        {
            await _registrationService.Register(registrationRequest);
            return Ok();
        }
    }
}