
namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица для объединения данных размеров
    /// </summary>
    public class UnionNamesAndDimensions : Base
    {
        public NamesDimensions? NamesDimensions { get; set; }
        public int? NamesDimensionsId { get; set; }

        public UnionCategoryAndTypeHuman? unionCategoryAndTypeHuman { get; set; } = null;
        public int? UnionCategoryAndTypeHumanId { get; set; }

        public IEnumerable<Dimensions>? dimensions { get; set; }
        public IEnumerable<Sizes>? sizes { get; set; }
    }
}