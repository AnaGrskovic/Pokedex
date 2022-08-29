using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models.Security
{
    public class RegistrationRequest
    {
        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; } = default!;

        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; } = default!;

        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = default!;
    }
}
