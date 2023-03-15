
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица с информацией о категори  по которым выборка размера(Обхват груди...)
    /// </summary>
    public class CriteriaOfDimensions : Base
    { 
        public int? MinSize { get; set; }
        [MaxLength(3)]
        public int? MaxSize { get; set; }

        public UnionNamesCriteriaOfDimensions? namesCriteriaOfDimensions { get; set; }
        public int? namesCriteriaOfDimensionsId { get; set; }

        public IEnumerable<Dimensions>? dimensions { get; set; }
    }
}
