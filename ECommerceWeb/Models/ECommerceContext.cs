using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {
        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommerceWeb.Models.City> Cities { get; set; }
    }
}