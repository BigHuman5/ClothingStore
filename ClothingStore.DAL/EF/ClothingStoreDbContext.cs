using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DAL.EF
{
    public class ClothingStoreDbContext : DbContext
    {
        public ClothingStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
