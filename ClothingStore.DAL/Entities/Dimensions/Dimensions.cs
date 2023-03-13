
namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица с информацией о данных размера товаров
    /// </summary>
    public class Dimensions : Base
    {
        public CriteriaOfDimensions? CriteriaOfDimensions { get; set; } = null;
        public int? CriteriaOfDimensionsId { get; set; } = null;

        public Sizes? sizes { get; set; } = null;
        public int? sizesId { get; set; } = null;
    }
}
