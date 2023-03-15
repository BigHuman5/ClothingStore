
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица с информацией о самом товаре
    /// </summary>
    public class Products : Base
    {
        public Cards? Card { get; set; }
        public int? cardId { get; set; }

        public Colors? Colors { get; set; }
        public int? colorId { get; set; }

        public Sizes? Sizes { get; set; }
        public int? sizeId { get; set; }


        public int howMany { get; set; } = 0;

        public int howManyPictures { get; set; } = 0;
    }
}
