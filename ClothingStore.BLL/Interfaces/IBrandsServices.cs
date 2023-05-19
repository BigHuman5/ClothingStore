

using ClothingStore.BLL.DTO;
using ClothingStore.Infrastructure.Services;

namespace ClothingStore.BLL.Interfaces
{
    public interface IBrandsServices
    {
        Task<List<BrandsDTO>> All(int orderByCody,bool invisible);
    }
}
