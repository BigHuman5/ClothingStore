
using ClothingStore.DAL.Entities;

namespace ClothingStore.DAL.Interfaces
{
    public interface IBrandsRepository
    {
        Task<List<Brands>> All(string? orderBy,bool invisible);
    }
}
