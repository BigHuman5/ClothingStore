using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DAL.Entities
{
    public class Dimensions : Base
    {
        public TypesDimensions? typeDimensions { get; set; } = null;
        public int? typeDimensionsId { get; set; }

        public NamesDimensions? nameDimensions { get; set; } = null;
        public int? nameDimensionsId { get; set;}

        [Required]
        public int MinSize { get; set; } = 0;
        public int MaxSize { get; set; } = 200;
        public string? StringSize { get; set; } = null;
    }
}
