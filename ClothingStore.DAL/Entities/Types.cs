
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    public class Types : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<TypesDimensions>? TypesDimensions { get; set; }
    }
}
