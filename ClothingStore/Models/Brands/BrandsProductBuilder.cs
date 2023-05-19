using AutoMapper;
using ClothingStore.BLL.DTO;
using ClothingStore.BLL.Interfaces;

namespace ClothingStore.Models.Brands
{
    public class BrandsProductBuilder
    {
        private IBrandsServices services;

        public BrandsProductBuilder(IBrandsServices services)
        {
            this.services = services;
        }

        public async Task<List<BrandsResponseModel>> BuildAll()
        {
            IEnumerable<BrandsDTO> brandsDTOs = await services.All(0,false);
            var mapper = new MapperConfiguration(
                cfg => cfg.CreateMap<BrandsDTO, BrandsResponseModel>())
                .CreateMapper();
            var brands = mapper
                .Map<IEnumerable<BrandsDTO>, List<BrandsResponseModel>>
                (brandsDTOs);
            return brands;
        }
    }
}
