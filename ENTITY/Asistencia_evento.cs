using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Asistencia_evento
    {
        public int id_asistencia { get; set; }
        public int id_usuario { get; set; }
        public int id_evento { get; set; }
        public DateTime fecha_asistencia_evento { get; set; }

        public Asistencia_evento()
        {
            fecha_asistencia_evento = DateTime.Now;
        }
    }
}
