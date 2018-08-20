using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDAlumnoEF.Models
{
    public class Alumno
    {
        [Key]
        public int AlumnoID { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        [StringLength(60, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        [StringLength(60, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        [StringLength(200, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        [Display(Name = "Número de teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar {0}")]
        [Display(Name = "Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}