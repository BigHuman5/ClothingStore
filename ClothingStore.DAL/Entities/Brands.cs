using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица со списком названий компаний (Брэндов)
    /// </summary>
     public class Brands : Base
    {

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string? Name { get; set; } = null;

        public int fakePopularity { get; set; } = 0;

        public int realPopulatiry { get; set; } = 0;

        public IEnumerable<Cards>? Cards { get; set; }

    }
}
