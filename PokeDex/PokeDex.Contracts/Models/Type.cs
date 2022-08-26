using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class Type
    {
        public int TypeId { get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<Pokemon> Pokemon { get; set; }

        public Type(
            string name)
        {
            Name = name;
            Pokemon = new List<Pokemon>();
        }
        public Type(
            int typeId,
            string name)
        {
            TypeId = typeId;
            Name = name;
            Pokemon = new List<Pokemon>();
        }
        public Type()
        {
        }
    }
}
