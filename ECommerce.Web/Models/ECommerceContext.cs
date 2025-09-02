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
    }
}