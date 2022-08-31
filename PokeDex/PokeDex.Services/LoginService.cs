using System.Security.Claims;
using PokeDex.Contracts.DTOs.Security;
using PokeDex.Contracts.Exceptions;
using PokeDex.Contracts.Models;
using PokeDex.Contracts.Models.Security;
using PokeDex.Contracts.Services;
using Microsoft.AspNetCore.Identity;

namespace PokeDex.Services
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenGenerator _tokenGenerator;
        public LoginService(UserManager<User> userManager, ITokenGenerator tokenGenerator)
        {
            _userManager = userManager;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<TokenDTO> Login(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);
            if (user == null)
            {
                throw new UserAuthenticationException("Invalid credentials!");
            }

            var isValidPassword = await _userManager.CheckPasswordAsync(user, loginRequest.Password);
            if (!isValidPassword)
            {
                throw new UserAuthenticationException("Invalid credentials!");
            }

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("UserName", user.Email),
                new Claim("Id", user.Id.ToString()),
            };
            return _tokenGenerator.Generate(claims);
        }
    }
}
