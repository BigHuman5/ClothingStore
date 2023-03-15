using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица со списком цветов товаров
    /// </summary>
    public class Colors : Base
    {
        [Required]
        public string? Name { get; set; } = null;

        [Required]
        [MaxLength(6)]
        [MinLength(3)]
        public string color { get; set; } = "fff";

        public IEnumerable<Products>? Products { get; set; }
    }
}
