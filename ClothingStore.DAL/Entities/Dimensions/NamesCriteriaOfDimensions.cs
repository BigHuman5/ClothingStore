
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица с названиями категорий по которым разница выборка размера(Обхват груди...)
    /// </summary>
    public class NamesCriteriaOfDimensions : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<UnionNamesCriteriaOfDimensions>? union { get; set; }
    }
}
