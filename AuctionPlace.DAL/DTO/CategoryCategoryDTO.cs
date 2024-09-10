using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("CategoryCategory")]
    public sealed class CategoryCategoryDTO : BaseDTO<int>
    {
        [ForeignKey("Category_Id")]
        public CategoryDTO? OriginalCategory { get; set; }

        [ForeignKey("ParentCategory_Id")]
        public CategoryDTO? ParentCategory { get; set; }
    }
}
