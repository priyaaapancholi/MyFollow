using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Product:CommonProperty
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public override DateTime CreatedDate { get; set; }
        public override DateTime LastModifiedDate { get; set; }
        public enum Platform {Mobile,IOT,Web }
        public Platform Type { get; set; } 
        [Required]
        public string HomepageURL { get; set; }
        [Required]
        public string AppstoreURL { get; set; }
        [Required]
        public string PlaystoreURL { get; set; }

        [ForeignKey("UserId")]
        public List<User> user { get; set; }

        public int ProductDetailId { get; set; }
        [ForeignKey("ProductDetailId")]
        public virtual ProductDetail productdetail { get; set; }

        public virtual List<ProductDetail> PD { get; set; }


        public List<Follow> folllow { get; set; }
    }
}