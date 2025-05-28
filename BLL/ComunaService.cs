using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class ComunaService
    {
        private readonly ComunaRepository comunaRepository;
        private readonly string connectionString;

        public ComunaService()
        {
            connectionString = "Data Source=localhost;Initial Catalog=IglesiaDB;Integrated Security=True";
            var connectionManager = new ConnectionManager();
            comunaRepository = new ComunaRepository(connectionManager);
        }

        public string Guardar(Comuna comuna)
        {
            try
            {
                comunaRepository.Guardar(comuna);
                return $"Comuna {comuna.nombre_comuna} guardada exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al guardar: {ex.Message}";
            }
        }

        public string Modificar(Comuna comuna)
        {
            try
            {
                // Validar que la comuna exista
                var comunaExistente = comunaRepository.BuscarPorId(comuna.id_comuna);
                if (comunaExistente == null)
                {
                    return $"Error al modificar: La comuna con ID {comuna.id_comuna} no existe";
                }

                comunaRepository.Modificar(comuna);
                return $"Comuna {comuna.nombre_comuna} modificada exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al modificar: {ex.Message}";
            }
        }

        public string Eliminar(int idComuna)
        {
            try
            {
                // Validar que la comuna exista
                var comuna = comunaRepository.BuscarPorId(idComuna);
                if (comuna == null)
                {
                    return $"Error al eliminar: La comuna con ID {idComuna} no existe";
                }

                comunaRepository.Eliminar(idComuna);
                return $"Comuna {comuna.nombre_comuna} eliminada exitosamente";
            }
            catch (Exception ex)
            {
                return $"Error al eliminar: {ex.Message}";
            }
        }

        public Comuna BuscarPorId(int idComuna)
        {
            return comunaRepository.BuscarPorId(idComuna);
        }

        public List<Comuna> ConsultarTodas()
        {
            return comunaRepository.ConsultarTodas();
        }
    }
}
