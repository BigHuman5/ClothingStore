
namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица для данных размеров(XL,XLL...)
    /// </summary>
    public class Sizes : Base
    {
        public string? Name { get; set; } = null;

        public UnionNamesAndDimensions? namesDimensions { get; set; } = null;
        public int? namesDimensionsId { get; set; } = null;

        public IEnumerable<Dimensions>? Dimensions { get; set; }
    }
}
