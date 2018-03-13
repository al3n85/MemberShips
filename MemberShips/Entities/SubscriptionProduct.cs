﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemberShips.Entities
{
    [Table("SubscriptionProduct")]
    public class SubscriptionProduct
    {
        [Required]
        [Key,Column(Order = 1)]

        public int SubscriptionId { get; set; }
        [Required]
        [Key,Column(Order = 2)]
        public int ProductId { get; set; }
        [NotMapped]
        public int OldSubscriptionId { get; set; }
        [NotMapped]
        public int OldProductId { get; set; }
    }
}