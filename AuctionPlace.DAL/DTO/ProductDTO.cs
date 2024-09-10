using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("Product")]
    public sealed class ProductDTO : BaseDTO<int>
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 50)]
        public string? Description { get; set; }

        public ICollection<CategoryDTO>? Categories { get; set; }
    }
}
