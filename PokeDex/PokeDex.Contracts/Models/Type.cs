using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class Type
    {
        public int TypeId { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<PokemonType> PokemonTypes { get; set; }

        public Type(
            string name)
        {
            Name = name;
            PokemonTypes = new List<PokemonType>();
        }
        public Type(
            int typeId,
            string name)
        {
            TypeId = typeId;
            Name = name;
            PokemonTypes = new List<PokemonType>();
        }
        public Type()
        {
        }
    }
}
