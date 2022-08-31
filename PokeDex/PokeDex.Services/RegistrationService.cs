using PokeDex.Contracts.Models;
using PokeDex.Contracts.Models.Security;
using PokeDex.Contracts.Services;
using Microsoft.AspNetCore.Identity;
using PokeDex.Contracts.Exceptions;

namespace PokeDex.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UserManager<User> _userManager;
        public RegistrationService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task Register(RegistrationRequest registrationRequest)
        {
            var existingUser = await _userManager.FindByEmailAsync(registrationRequest.Email);
            if (existingUser != null)
            {
                throw new NullReferenceException("User already exists!");
            }

            User user = new User(
                registrationRequest.FirstName,
                registrationRequest.LastName,
                registrationRequest.Email);
            user.UserName = user.Email;

            var result = await _userManager.CreateAsync(user, registrationRequest.Password);
            if (!result.Succeeded)
            {
                var error = string.Join("", result.Errors.SelectMany(x => x.Description));
                throw new UserAuthenticationException(error);
            }
        }
    }
}

