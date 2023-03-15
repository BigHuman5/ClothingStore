
using System.ComponentModel.DataAnnotations;
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица со списком типов одежды (Футболки, платья....)
    /// </summary>
    public class Category : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<UnionCategoryAndTypeHuman>? TypesDimensions { get; set; }
        public IEnumerable<Subcategory>? Subcategory { get; set; }
    }
}
