
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BLL.DTO
{
    public class BrandsDTO : BaseDTO
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        public string? Name { get; set; } = null;

        public int fakePopularity { get; set; } = 0;

        public int realPopularity { get; set; } = 0;

    }
}
