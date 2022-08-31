using PokeDex.Contracts.DTOs.Security;
using System.Security.Claims;

namespace PokeDex.Contracts.Services
{
    public interface ITokenGenerator
    {
        TokenDTO Generate(List<Claim> claims);
    }
}
