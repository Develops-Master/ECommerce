using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(100, ErrorMessage = "The field {0} must be a maximum length of {1} characters.")]
        [Display(Name = "Ciudad")]
        public string Name { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }




    }
}