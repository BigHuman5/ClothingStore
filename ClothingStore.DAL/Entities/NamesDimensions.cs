using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.DAL.Entities
{
    public class NamesDimensions : Base
    {
        [Required]
        public string? Name { get; set; } = "";

        public IEnumerable<Dimensions>? Dimensions { get; set; }
    }
}
