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
        
        
        [Required]
        public string UserName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        public String  EmailId{ get; set; }

        public AddressInfo Address { get; set;}

        public string CompanyName { get; set; }

        [Url]
        public string WebsiteURL { get; set; }

        public int FoundedYear { get; set; }

        public string Description { get; set; }

        //refers relation between product owner and product..
        public virtual ICollection<Product> product { get; set; }

        //refers relation between follow product and user
        public virtual ICollection<Follow> folllow { get; set; }





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
            [Phone]
            public int ContactNo { get; set; }
        }
    }
}