
using System.ComponentModel.DataAnnotations;
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица со списком типов одежды (Футболки, платья....)
    /// </summary>
    public class Types : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<TypesDimensions>? TypesDimensions { get; set; }
    }
}
