using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models.Security
{
    public class LoginRequest
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = default!;
    }
}
