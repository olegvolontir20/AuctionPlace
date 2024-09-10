namespace AuctionPlace.DAL.DTO
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class UserDTO : IdentityUser<int>
    {
        [Required]
        [Range(0, 10)]
        public float TrustScore { get; set; }

        public ICollection<WalletDTO>? Wallets { get; set; }

        public ICollection<UserScoringDTO>? RecievedScores { get; set; }

        public ICollection<UserScoringDTO>? GivenScores { get; set; }

        public ICollection<BidDTO>? Bids { get; set; }

        public ICollection<AuctionDTO>? OfferedAucitons { get; set; }

        public ICollection<AuctionDTO>? WonAuctions { get; set; }
    }
}
