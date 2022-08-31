using PokeDex.Contracts.DTOs.Security;
using PokeDex.Contracts.Models.Security;

namespace PokeDex.Contracts.Services
{
    public interface ILoginService
    {
        Task<TokenDTO> Login(LoginRequest loginRequest);
    }
}
