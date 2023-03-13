
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица с названиями данных(XL,XXL)
    /// </summary>
    public class NamesDimensions : Base
    {
        [Required]
        public string? Name { get; set; } = "";
        public IEnumerable<UnionNamesAndDimensions>? union { get; set; }
    }
}
