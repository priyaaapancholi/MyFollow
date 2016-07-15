using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public abstract class CommonProperty
    {
        [Key]
        [Required]
        public  int Id { get; set; }

        public  DateTime CreatedDate { get; set; }

        public  DateTime LastModifiedDate { get; set; }
    }
}