// <copyright file="WalletDTO.cs" company="Transilvania University of Brasov">
// Copyright (c) Transilvania University of Brasov.
// Student name: Volontir Oleg.
// All rights reserved.
// </copyright>

namespace AuctionPlace.DAL.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("Wallet")]
    public sealed class WalletDTO : BaseDTO<int>
    {
        [Required]
        public float Balance { get; set; }

        [Required]
        [StringLength(5)]
        public string? Currency { get; set; }

        [Required]
        [ForeignKey("Owner_Id")]
        required public UserDTO Owner { get; set; }
    }
}
