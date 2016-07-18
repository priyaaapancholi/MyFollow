using MyFollow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace MyFollow.Models
{
    public class ContextFollow : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductUpdate> ProductUpdate { get; set; }
        public DbSet<Follow> Follow { get; set; }


        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Product>().HasMany(i => i.User).WithRequired().WillCascadeOnDelete(false);
        // }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}