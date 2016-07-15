using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFollow.Models
{
    public abstract class CommonProperty
    {
        public abstract DateTime CreatedDate { get; set; }
        public abstract DateTime LastModifiedDate { get; set; }
    }
}