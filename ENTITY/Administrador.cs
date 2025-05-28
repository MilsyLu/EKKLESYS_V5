using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Administrador
    {
        public int id_administrador { get; set; }
        public int id_usuario { get; set; }
        public string nivel_acceso { get; set; }
    }
}
