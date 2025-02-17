using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaGo.Shared.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }= null!;
        public string Apellido { get; set; } = null!;
        public string Correo { get; set; } = null!;

    }
}
