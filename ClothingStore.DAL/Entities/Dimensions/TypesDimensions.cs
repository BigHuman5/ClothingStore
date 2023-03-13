
namespace ClothingStore.DAL.Entities.Dimensions
{
    /// <summary>
    /// Таблица для объединения данных человека и типа одежды для простоты работы в дальнейшем
    /// </summary>
    public class TypesDimensions : Base
    {
        public Types? type { get; set; } = null; // Тип одежды(фут,платье)
        public int? typeId { get; set; }

        public TypesHuman? typeHuman { get; set; } = null; // Тип человека(муж,жен)
        public int? typeHumanId { get; set; }

        public IEnumerable<UnionNamesAndDimensions>? namesDimensions { get; set; }
        public IEnumerable<UnionNamesCriteriaOfDimensions>? namesCriteria { get; set; }

    }
}
