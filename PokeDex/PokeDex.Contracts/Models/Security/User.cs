using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PokeDex.Contracts.Models
{
    public class User : IdentityUser<int>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public User(
            string firstName,
            string lastName,
            string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public User(
           string firstName,
           string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User()
        {
        }
    }
}
