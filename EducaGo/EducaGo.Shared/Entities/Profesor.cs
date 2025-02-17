using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaGo.Shared.Entities
{
    public class Profesor
    {
        int Id { get; set; }
        string Nombre { get; set; } = null!;
        string Apellido { get; set; } = null!;
        string Correo { get; set; } = null!;
        string Telefono { get; set; } = null!;
        string Direccion { get; set; } = null!;
        string Cedula { get; set; } = null!;
        string Especialidad { get; set; } = null!;
        string GradoAcademico { get; set; } = null!;
        string Experiencia { get; set; } = null!;
        string Foto { get; set; } = null!;
        string Curriculum { get; set; } = null!;
        string Estado { get; set; } = null!;


    }
}
