using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class User:CommonProperty
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
       
        public  override DateTime CreatedDate { get; set; }
        public  override DateTime LastModifiedDate { get; set; }
        public AddressInfo Address { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteURL { get; set; }
        public int FoundedYear { get; set; }
        public string Description { get; set; }

        [ForeignKey("ProductId")]
        public List<Product> product { get; set; }

        public List<Follow> folllow { get; set; }





        public class AddressInfo
        {
            [Required]
            public string Street1 { get; set; }
            [Required]
            public string Street2 { get; set; }
            [Required]
            public string CityName { get; set; }
            [Required]
            public string StateName { get; set; }
            [Required]
            public int PIN { get; set; }
            [Required]
            public int ContactNo { get; set; }
        }
    }
}