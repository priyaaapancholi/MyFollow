using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public enum Type {Mobile,IOT,Web }
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

        public virtual ICollection<ProductDetail> PD { get; set; }


        public ICollection<Follow> folllow { get; set; }
    }
}