using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    [Table("UserScoring")]
    public sealed class UserScoringDTO : BaseDTO<int>
    {
        [ForeignKey("Scorer_Id")]
        public UserDTO? Scorer { get; set; }

        [ForeignKey("Target_Id")]
        public UserDTO? Target { get; set; }

        [Required]
        [Range(0, 0.1)]
        public float Score { get; set; }
    }
}
