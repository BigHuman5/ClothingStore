using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
