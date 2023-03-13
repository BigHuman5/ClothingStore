using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Базовый класс который будет наследоваться всем остальным.
    /// </summary>
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}
