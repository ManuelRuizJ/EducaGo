using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaGo.Shared.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Contraseña { get; set; }
        public string Rol { get; set; }
    }
}
