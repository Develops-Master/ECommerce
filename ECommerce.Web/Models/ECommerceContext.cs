using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerce.Web.Models
{
    public class ECommerceContext :DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Web.Models.City> Cities { get; set; }
    }
}