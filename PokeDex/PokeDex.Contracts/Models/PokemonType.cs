using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class PokemonType
    {
        [Required]
        public int PokemonId { get; }
        [Required]
        public Pokemon Pokemon { get; }
        [Required]
        public int TypeId { get; }
        [Required]
        public Type Type { get; }

        public PokemonType(
            int pokemonId,
            Pokemon pokemon,
            int typeId,
            Type type)
        {
            PokemonId = pokemonId;
            Pokemon = pokemon;
            Type = type;
            TypeId = typeId;
        }

        public PokemonType()
        {
        }
    }
}
