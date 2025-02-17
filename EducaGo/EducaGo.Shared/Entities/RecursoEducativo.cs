using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducaGo.Shared.Entities
{
    public class RecursoEducativo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Tipo { get; set; } = null!;
    }
}
