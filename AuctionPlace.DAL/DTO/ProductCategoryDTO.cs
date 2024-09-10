using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("ProductCategory")]
    public sealed class ProductCategoryDTO : BaseDTO<int>
    {
        [ForeignKey("Product_Id")]
        public ProductDTO? Product { get; set; }

        [ForeignKey("Category_Id")]
        public CategoryDTO? Category { get; set; }
    }
}
