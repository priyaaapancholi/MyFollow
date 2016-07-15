using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public class Follow
    {
        [Key]
        public int FollowId { get; set; }

        [ForeignKey("UserId")]
        public List<User> user { get; set; }

        [ForeignKey("ProductId")]
        public List<Product> product { get; set; }
    }
}