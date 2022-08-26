using System.ComponentModel.DataAnnotations;

namespace PokeDex.Contracts.Models
{
    public class Type
    {
        public int TypeId { get; }
        [Required]
        public string Name { get; set; }

        public Type(
            string name)
        {
            Name = name;
        }
        public Type(
            int typeId,
            string name)
        {
            TypeId = typeId;
            Name = name;
        }
        public Type()
        {
        }
    }
}
