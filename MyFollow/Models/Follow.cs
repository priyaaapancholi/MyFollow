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


        //refers relation between user and follow class..
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        //refers relation between product and follow class..
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}