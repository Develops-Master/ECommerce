using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Web.Models
{
    public class City
    {
        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres.", MinimumLength = 3)]
        [Display(Name = "Ciudad")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "El campo {0} solo puede contener letras.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Departamento")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un departamento.")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}