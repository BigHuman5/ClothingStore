using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IBrandsRepository Brands { get; }

        void Save();
    }
}
