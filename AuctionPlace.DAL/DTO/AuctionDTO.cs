using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("Auction")]
    public sealed class AuctionDTO : BaseDTO<int>
    {
        [Required]
        public bool Finished { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        [Required]
        public DateTime CloseDate { get; set; }

        [Required]
        [StringLength(5)]
        public string? Currency { get; set; }

        [Required]
        public float StartingPrice { get; set; }

        [Required]
        [ForeignKey("Offerer_Id")]
        public UserDTO? Offerer { get; set; }

        [Required]
        [ForeignKey("Product_Id")]
        public ProductDTO? OfferedProduct { get; set; }

        [Required]
        [ForeignKey("Winner_Id")]
        public UserDTO? Winner { get; set; }

        public ICollection<BidDTO>? Bids { get; set; }
    }
}
