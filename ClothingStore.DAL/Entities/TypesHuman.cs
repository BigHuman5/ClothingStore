
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    public class TypesHuman : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<TypesDimensions>? TypesDimensions { get; set; }
    }
}
