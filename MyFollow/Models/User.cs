using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteURL { get; set; }
        public int FoundedYear { get; set; }
        public string Description { get; set; }

        [ForeignKey("ProductId")]
        public List<Product> product { get; set; }

        public ICollection<Follow> folllow { get; set; }





       /* public class AddressInfo
        {
            public string Street1 { get; set; }
            public string Street2 { get; set; }
            public string CityName { get; set; }
            public string StateName { get; set; }
            public int PIN { get; set; }
            public int ContactNo { get; set; }
        }*/
    }
}