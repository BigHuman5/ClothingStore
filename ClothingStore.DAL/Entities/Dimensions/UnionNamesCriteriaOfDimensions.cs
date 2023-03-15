using System.ComponentModel.DataAnnotations;


namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица с информацией о категорий по которым разница выборка размера(Обхват груди...)
    /// </summary>
    public class UnionNamesCriteriaOfDimensions : Base
    {
        public NamesCriteriaOfDimensions? NamesCriteriaOfDimensions { get; set; }
        public int? NamesCriteriaOfDimensionsId { get; set; }

        public UnionCategoryAndTypeHuman? unionCategoryAndTypeHuman { get; set; }
        public int? UnionCategoryAndTypeHumanId { get; set; }

        public IEnumerable<CriteriaOfDimensions>? criteriaOfDimensions { get; set; }

    }
}
