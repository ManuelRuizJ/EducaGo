using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaGo.Shared.Entities
{
    public class ProgresoEstudiante
    {
        int Id { get; set; }
        int IdEstudiante { get; set; }
        int IdCurso { get; set; }
        int IdLeccion { get; set; }
        int IdTema { get; set; }
        int IdRecurso { get; set; }
        string Estado { get; set; } = null!;
        string Calificacion { get; set; } = null!;


    }
}
