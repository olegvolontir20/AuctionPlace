using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("Category")]
    public sealed class CategoryDTO : BaseDTO<int>
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Description { get; set; }

        public ICollection<ProductDTO>? Products { get; set; }

        public ICollection<CategoryDTO>? ParentCategories { get; set; }

        public ICollection<CategoryDTO>? ChildCategories { get; set; }
    }
}
