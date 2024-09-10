using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("AuctionConfig")]
    public sealed class AuctionConfigDTO : BaseDTO<int>
    {
        [Required]
        public int MaxOffers { get; set; }

        [Required]
        public int MaxOffersPerCategory { get; set; }

        [Required]
        public float MinimalAllowedScore { get; set; }

        [Required]
        public float MinimalBidIncreasePercentage { get; set; }
    }
}
