﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MemberShips.Entities
{
    [Table("Subscription")]
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title  { get; set; }
        [MaxLength(2048)]
        public string Description { get; set;}
        [MaxLength(20)]
        [DisplayName("Registration Code")]
        public string  RegistrationCode { get; set; }
    }
}