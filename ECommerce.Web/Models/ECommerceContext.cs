using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ECommerce.Web.Models
{
    public class ECommerceContext :DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {
            
        }

        override protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Department>()
            //    .HasMany(e => e.Cities)
            //    .WithRequired(e => e.Department)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Web.Models.City> Cities { get; set; }
    }
}