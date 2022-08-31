using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class Pokemon
    {
        public int PokemonId { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<PokemonType> PokemonTypes { get; set; }
        [Required]
        public string Description { get; set; }
        public int EvolvesFromPokemonId { get; set; }
        public Pokemon EvolvesFrom { get; set; }
        public int EvolvesToPokemonId { get; set; }
        public List<Pokemon> EvolvesTo { get; set; }

        public Pokemon(
            string name,
            List<PokemonType> pokemonTypes,
            string description,
            int evolvesFromPokemonId,
            Pokemon evolvesFrom,
            int evolvesToPokemonId,
            List<Pokemon> evolvesTo)
        {
            Name = name;
            PokemonTypes = pokemonTypes;   
            Description = description;
            EvolvesFromPokemonId = evolvesFromPokemonId;
            EvolvesFrom = evolvesFrom;
            EvolvesToPokemonId = evolvesToPokemonId;
            EvolvesTo = evolvesTo;
        }
        public Pokemon()
        {
        }
    }
}
