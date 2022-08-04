using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class Pokemon
    {
        public int PokemonId { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<Type> Type { get; set; }
        [Required]
        public string Description { get; set; }
        public Pokemon evolvesFrom { get; set; }
        public List<Pokemon> evolvesTo { get; set; }
    }
}
