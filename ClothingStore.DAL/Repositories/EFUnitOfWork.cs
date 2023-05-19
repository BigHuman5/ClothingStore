using ClothingStore.DAL.EF;
using ClothingStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ClothingStoreDbContext db;

        public EFUnitOfWork(ClothingStoreDbContext db)
        {
            this.db = db;
        }

        private BrandsRepository? brandsRepository;
        public IBrandsRepository Brands
        {
            get
            {
                if (brandsRepository == null)
                    brandsRepository = new BrandsRepository(db);
                return brandsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
