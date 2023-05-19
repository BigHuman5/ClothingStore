using ClothingStore.DAL.EF;
using ClothingStore.DAL.Entities;
using ClothingStore.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DAL.Repositories
{
    public class BrandsRepository : IBrandsRepository
    {
        private ClothingStoreDbContext data;

        public BrandsRepository(ClothingStoreDbContext data)
        {
            this.data = data;
        }

        public async Task<List<Brands>> All(string? orderBy=null,bool invisible=false)
        {
            var result = await data.Brands
                .Where(p=>p.isDeleted==invisible)
                .ToListAsync();

            return orderBy switch
            {
                "Name" => result.OrderBy(p => p.Name).ToList(),
                "Populatiry" => result.OrderBy(p => p.realPopularity).ToList(),
                _ => result.OrderBy(p => p.Id).ToList(),
            };
        }
    }
}
