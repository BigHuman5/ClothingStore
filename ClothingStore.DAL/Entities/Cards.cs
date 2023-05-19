
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица для карточки товара
    /// </summary>
    public class Cards : Base
    {
        public string Name { get; set; } = "Not name";

        public Brands? Brand { get; set; }
        public int? brandId { get; set; } = null;

        public Subcategory? Subcategory { get; set; }
        public int? subcategoryId { get; set; } = null;
        public float Price { get; set; } = 0;
        public Collections? Collections { get; set; }
        public int? collectionId { get; set; } = null;

        [MaxLength(500)]
        public string About { get; set; } = "Not information";

        public string Addition { get; set; } = "Not information";

        public int fakePopularity { get; set; } = 0;

        public int realPopularity { get; set; } = 0;
    }
}
