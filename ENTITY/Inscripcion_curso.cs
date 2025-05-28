using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Inscripcion_curso
    {
        public int id_inscripcion { get; set; }
        public int id_usuario { get; set; }
        public int id_curso { get; set; }
        public DateTime fecha_inscripcion_curso { get; set; }

        public Inscripcion_curso()
        {
            fecha_inscripcion_curso = DateTime.Now;
        }
    }
}
