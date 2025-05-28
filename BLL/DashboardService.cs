using System;
using System.Collections.Generic;
using DAL;
using ENTITY;

namespace BLL
{
    public class DashboardService
    {
        private readonly DashboardRepository dashboardRepository;
        private readonly string connectionString;

        public DashboardService()
        {
            connectionString = "Data Source=localhost;Initial Catalog=IglesiaDB;Integrated Security=True";
            var connectionManager = new ConnectionManager();
            dashboardRepository = new DashboardRepository(connectionManager);
        }

        public DashboardDTO ObtenerDatosDashboard()
        {
            try
            {
                return dashboardRepository.ObtenerEstadisticasGenerales();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos del dashboard: {ex.Message}", ex);
            }
        }

        public List<EstadisticaMensualDTO> ObtenerEstadisticasInscripcionesMensuales()
        {
            try
            {
                return dashboardRepository.ObtenerInscripcionesPorMes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener estadísticas mensuales: {ex.Message}", ex);
            }
        }

        public string GenerarResumenEjecutivo()
        {
            try
            {
                var datos = ObtenerDatosDashboard();

                var resumen = $"=== RESUMEN EJECUTIVO ===\n\n";
                resumen += $"📊 USUARIOS:\n";
                resumen += $"   • Total de usuarios: {datos.TotalUsuarios}\n";
                resumen += $"   • Miembros activos: {datos.TotalMiembros}\n";
                resumen += $"   • Administradores: {datos.TotalAdministradores}\n";
                resumen += $"   • Registros este mes: {datos.UsuariosRegistradosEsteMes}\n\n";

                resumen += $"📚 CURSOS:\n";
                resumen += $"   • Total de cursos: {datos.TotalCursos}\n";
                resumen += $"   • Cursos activos: {datos.CursosActivos}\n";
                resumen += $"   • Total inscripciones: {datos.TotalInscripciones}\n";
                resumen += $"   • Inscripciones este mes: {datos.InscripcionesEsteMes}\n\n";

                resumen += $"📅 EVENTOS:\n";
                resumen += $"   • Total de eventos: {datos.TotalEventos}\n";
                resumen += $"   • Eventos próximos: {datos.EventosProximos}\n";
                resumen += $"   • Total asistencias: {datos.TotalAsistencias}\n";
                resumen += $"   • Asistencias este mes: {datos.AsistenciasEsteMes}\n\n";

                if (datos.CursosMasPopulares.Count > 0)
                {
                    resumen += $"🏆 CURSO MÁS POPULAR:\n";
                    var cursoTop = datos.CursosMasPopulares[0];
                    resumen += $"   • {cursoTop.NombreCurso}\n";
                    resumen += $"   • {cursoTop.NumeroInscripciones} inscripciones ({cursoTop.PorcentajeOcupacion}% ocupación)\n\n";
                }

                if (datos.ProximosEventos.Count > 0)
                {
                    resumen += $"⏰ PRÓXIMO EVENTO:\n";
                    var eventoProximo = datos.ProximosEventos[0];
                    resumen += $"   • {eventoProximo.NombreEvento}\n";
                    resumen += $"   • {eventoProximo.FechaInicio:dd/MM/yyyy} en {eventoProximo.Lugar}\n";
                    resumen += $"   • {eventoProximo.DiasRestantes} días restantes\n\n";
                }

                resumen += $"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm}";

                return resumen;
            }
            catch (Exception ex)
            {
                return $"Error al generar resumen: {ex.Message}";
            }
        }

        public Dictionary<string, object> ObtenerIndicadoresClave()
        {
            try
            {
                var datos = ObtenerDatosDashboard();
                var indicadores = new Dictionary<string, object>();

                // Tasa de ocupación promedio de cursos
                decimal tasaOcupacionCursos = 0;
                if (datos.CursosMasPopulares.Count > 0)
                {
                    decimal sumaOcupacion = 0;
                    foreach (var curso in datos.CursosMasPopulares)
                    {
                        sumaOcupacion += curso.PorcentajeOcupacion;
                    }
                    tasaOcupacionCursos = sumaOcupacion / datos.CursosMasPopulares.Count;
                }

                // Porcentaje de miembros
                decimal porcentajeMiembros = datos.TotalUsuarios > 0 ?
                    (decimal)datos.TotalMiembros / datos.TotalUsuarios * 100 : 0;

                // Promedio de asistentes por evento
                decimal promedioAsistentesPorEvento = datos.TotalEventos > 0 ?
                    (decimal)datos.TotalAsistencias / datos.TotalEventos : 0;

                indicadores.Add("TasaOcupacionCursos", Math.Round(tasaOcupacionCursos, 1));
                indicadores.Add("PorcentajeMiembros", Math.Round(porcentajeMiembros, 1));
                indicadores.Add("PromedioAsistentesPorEvento", Math.Round(promedioAsistentesPorEvento, 1));
                indicadores.Add("CrecimientoUsuarios", datos.UsuariosRegistradosEsteMes);
                indicadores.Add("ActividadMensual", datos.InscripcionesEsteMes + datos.AsistenciasEsteMes);

                return indicadores;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al calcular indicadores clave: {ex.Message}", ex);
            }
        }
    }
}
