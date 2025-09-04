using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Web.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Compañía")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "El campo {0} solo puede contener letras.")]
        [DataType(DataType.Text)]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(200, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Dirección")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Display(Name = "Logo")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Departamento")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un departamento.")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Ciudad")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una ciudad.")]
        public int CityId { get; set; }

        public virtual Department Department { get; set; }

        public virtual City City { get; set; }
    }
}