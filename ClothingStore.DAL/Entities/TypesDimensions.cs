using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DAL.Entities
{
    public class TypesDimensions : Base
    {
        public Types? type { get; set; } = null;
        public int? typeId { get; set; }

        public TypesHuman? typeHuman { get; set; } = null;
        public int? typeHumanId { get; set; }

        public IEnumerable<Dimensions>? Dimensions { get; set; }

    }
}
