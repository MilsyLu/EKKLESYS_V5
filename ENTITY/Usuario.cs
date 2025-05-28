using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string telefono_2 { get; set; }
        public string email { get; set; }
        public string cedula { get; set; }
        public string clave { get; set; }
        public string es_miembro { get; set; }
        public string ruta_imagen_usuario { get; set; }
        public int id_comuna { get; set; }
        public string es_administrador { get; set; }

        public Usuario()
        {
            es_miembro = "N";
            es_administrador = "N";
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido_paterno}"; }
        }
    }
}
