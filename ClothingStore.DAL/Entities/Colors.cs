using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    public class Colors : Base
    {
        [Required]
        public string? Name { get; set; } = null;

        [Required]
        public string color { get; set; } = "fff";
    }
}
