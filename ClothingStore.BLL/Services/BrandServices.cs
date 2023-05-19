using ClothingStore.BLL.DTO;
using ClothingStore.BLL.Interfaces;
using ClothingStore.DAL.Interfaces;
using ClothingStore.Infrastructure.Services;

namespace ClothingStore.BLL.Services
{
    public class BrandServices : IBrandsServices
    {
        private IUnitOfWork db;

        public BrandServices(IUnitOfWork db)
        {
            this.db = db;
        }

        public async Task<List<BrandsDTO>> All(int orderByCode=0, bool invisible=false)
        {
            var orderBy = orderByCode switch
            {
                0 => "Name",
                1 => "Populatiry",
                _ => "Id",
            };
            var result = await db.Brands.All(null,invisible);

            List<BrandsDTO> resultList = new List<BrandsDTO>();

            foreach (var e in result)
            {
                BrandsDTO dTO = new BrandsDTO()
                {
                    Id= e.Id,
                    Name = e.Name,
                    realPopularity = e.realPopularity,
                    fakePopularity= e.fakePopularity,
                    isDeleted= e.isDeleted,
                };
                resultList.Add(dTO);
            }
            return resultList;
        }
    }
}
