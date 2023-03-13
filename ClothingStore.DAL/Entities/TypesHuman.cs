
using System.ComponentModel.DataAnnotations;
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица по список названий кому принадлежит одежда(Мужчина, девушка, дети...)
    /// </summary>
    public class TypesHuman : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<TypesDimensions>? TypesDimensions { get; set; }
    }
}
