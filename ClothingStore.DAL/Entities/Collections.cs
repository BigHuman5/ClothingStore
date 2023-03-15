
namespace ClothingStore.DAL.Entities
{
    /// <summary>
    /// Таблица для коллекций одежды.
    /// </summary>
    public class Collections : Base
    {
        public string Name { get; set; } = "Not name";

        public bool isActual { get; set; } = false;

        public IEnumerable<Cards>? Cards { get; set; }
    }
}
