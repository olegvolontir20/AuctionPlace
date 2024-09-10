﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionPlace.DAL.DTO
{
    public class BaseDTO<T>
    {
        public T Id { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
