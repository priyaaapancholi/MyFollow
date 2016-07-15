using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public enum Platform { Mobile, IOT, Web }
    public class Product:CommonProperty
    {
        [Required]
        public string ProductName { get; set; }

        public string Description { get; set; }

        public Platform Type { get; set; } 

        [Required]
        public string HomepageURL { get; set; }

        [Required]
        public string AppstoreURL { get; set; }

        [Required]
        public string PlaystoreURL { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int ProductDetailId { get; set; }
        [ForeignKey("ProductDetailId")]
        public virtual ProductDetail Productdetail { get; set; }

       


        public ICollection<Follow> Folllow { get; set; }
    }
}