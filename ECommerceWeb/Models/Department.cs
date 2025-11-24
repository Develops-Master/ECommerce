using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(100, ErrorMessage = "The field {0} must be a maximum length of {1} characters.")]
        [Display(Name = "Departamento")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}