using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("Bid")]
    public sealed class BidDTO : BaseDTO<int>
    {
        [ForeignKey("Auction_Id")]
        public AuctionDTO? Auction { get; set; }

        [ForeignKey("User_Id")]
        public UserDTO? Bidder { get; set; }

        [Required]
        public float BidValue { get; set; }

        [Required]
        [StringLength(5)]
        public string? Currency { get; set; }
    }
}
