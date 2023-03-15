
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица для подкатегорий товаров (их названий)
    /// </summary>
    public class Subcategory : Base
    {
        public string Name { get; set; } = "Not name";

        public UnionCategoryAndTypeHuman? unionCategoryAndTypeHuman { get; set; }
        public int? unionCategoryAndTypeHumanId { get; set; }

        public IEnumerable<Cards>? Cards { get; set; }
    }
}
