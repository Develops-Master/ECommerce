using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerceWeb.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage ="The field {0} is required.")]
        [StringLength(100, ErrorMessage ="The field {0} must be a maximum length of {1} characters.")]
        [Display(Name ="Compañia")]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(20, ErrorMessage = "The field {0} must be a maximum length of {1} characters.")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(200, ErrorMessage = "The field {0} must be a maximum length of {1} characters.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(20, ErrorMessage = "The field {0} must be a maximum length of {1} characters.")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "The field {0} is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a {0}.")]
        public int DepartmentId { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "The field {0} is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a {0}.")]
        public int CityId { get; set; }

        public virtual Department Department { get; set; }

        public virtual City City { get; set; }


    }
}