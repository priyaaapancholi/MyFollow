﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class ProductDetail
    {
        [Key]
        [Required]
        public int ProductDetailId { get; set; }
      
        [Required]
        [MaxLength(1100)]
        public string Detail { get; set; }
        public string Media { get; set; }
        [Required]
        [MaxLength(140)]
        public string Introduction{ get; set; }

      
        public Product product { get; set; }

    }
}