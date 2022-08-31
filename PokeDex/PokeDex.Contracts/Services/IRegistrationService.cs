using PokeDex.Contracts.Models.Security;

namespace PokeDex.Contracts.Services
{
    public interface IRegistrationService
    {
        Task Register(RegistrationRequest registrationRequest);
    }
}

