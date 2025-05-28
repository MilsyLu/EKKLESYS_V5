using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using ENTITY;

namespace DAL
{
    public class DashboardRepository
    {
        private readonly ConnectionManager connectionManager;

        public DashboardRepository(ConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
        }

        public DashboardDTO ObtenerEstadisticasGenerales()
        {
            var dashboard = new DashboardDTO();

            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();

                // Estadísticas de Usuarios
                dashboard.TotalUsuarios = ObtenerTotalUsuarios(connection);
                dashboard.TotalMiembros = ObtenerTotalMiembros(connection);
                dashboard.TotalAdministradores = ObtenerTotalAdministradores(connection);
                dashboard.UsuariosRegistradosEsteMes = ObtenerUsuariosRegistradosEsteMes(connection);

                // Estadísticas de Cursos
                dashboard.TotalCursos = ObtenerTotalCursos(connection);
                dashboard.CursosActivos = ObtenerCursosActivos(connection);
                dashboard.TotalInscripciones = ObtenerTotalInscripciones(connection);
                dashboard.InscripcionesEsteMes = ObtenerInscripcionesEsteMes(connection);

                // Estadísticas de Eventos
                dashboard.TotalEventos = ObtenerTotalEventos(connection);
                dashboard.EventosProximos = ObtenerEventosProximos(connection);
                dashboard.TotalAsistencias = ObtenerTotalAsistencias(connection);
                dashboard.AsistenciasEsteMes = ObtenerAsistenciasEsteMes(connection);

                // Listas detalladas
                dashboard.CursosMasPopulares = ObtenerCursosMasPopulares(connection);
                dashboard.ProximosEventos = ObtenerProximosEventosDetalle(connection);
                dashboard.UsuariosRecientes = ObtenerUsuariosRecientes(connection);
            }

            return dashboard;
        }

        private int ObtenerTotalUsuarios(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Usuarios", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalMiembros(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Usuarios WHERE es_miembro = 'S'", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalAdministradores(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Usuarios WHERE es_administrador = 'S'", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerUsuariosRegistradosEsteMes(OracleConnection connection)
        {
            using (var command = new OracleCommand(@"
                SELECT COUNT(*) FROM Usuarios 
                WHERE EXTRACT(MONTH FROM FECHA_NACIMIENTO) = EXTRACT(MONTH FROM SYSDATE) 
                AND EXTRACT(YEAR FROM FECHA_NACIMIENTO) = EXTRACT(YEAR FROM SYSDATE)", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalCursos(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Cursos", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerCursosActivos(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Cursos WHERE fecha_fin_curso >= SYSDATE", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalInscripciones(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Inscripcion_curso", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerInscripcionesEsteMes(OracleConnection connection)
        {
            using (var command = new OracleCommand(@"
                SELECT COUNT(*) FROM Inscripcion_curso 
                WHERE EXTRACT(MONTH FROM FECHA_INSCRIPCION_CURSO) = EXTRACT(MONTH FROM SYSDATE) 
                AND EXTRACT(YEAR FROM FECHA_INSCRIPCION_CURSO) = EXTRACT(YEAR FROM SYSDATE)", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalEventos(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Eventos", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerEventosProximos(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Eventos WHERE fecha_inicio_evento >= SYSDATE", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerTotalAsistencias(OracleConnection connection)
        {
            using (var command = new OracleCommand("SELECT COUNT(*) FROM Asistencia_evento", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private int ObtenerAsistenciasEsteMes(OracleConnection connection)
        {
            using (var command = new OracleCommand(@"
                SELECT COUNT(*) FROM Asistencia_evento 
                WHERE EXTRACT(MONTH FROM FECHA_ASISTENCIA_EVENTO) = EXTRACT(MONTH FROM SYSDATE) 
                AND EXTRACT(YEAR FROM FECHA_ASISTENCIA_EVENTO) = EXTRACT(YEAR FROM SYSDATE)", connection))
            {
                var result = command.ExecuteScalar();
                return ConvertirAEntero(result);
            }
        }

        private List<CursoPopularDTO> ObtenerCursosMasPopulares(OracleConnection connection)
        {
            var cursos = new List<CursoPopularDTO>();

            using (var command = new OracleCommand(@"
                SELECT c.id_curso, c.nombre_curso, c.fecha_inicio_curso, c.capacidad_max_curso,
                       COUNT(ic.id_usuario) as num_inscripciones
                FROM Cursos c
                LEFT JOIN Inscripcion_curso ic ON c.id_curso = ic.id_curso
                WHERE c.fecha_fin_curso >= SYSDATE
                GROUP BY c.id_curso, c.nombre_curso, c.fecha_inicio_curso, c.capacidad_max_curso
                ORDER BY COUNT(ic.id_usuario) DESC
                FETCH FIRST 5 ROWS ONLY", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var inscripciones = ConvertirAEntero(reader["num_inscripciones"]);
                        var capacidad = ConvertirAEntero(reader["capacidad_max_curso"]);
                        var porcentaje = capacidad > 0 ? (decimal)inscripciones / capacidad * 100 : 0;

                        cursos.Add(new CursoPopularDTO
                        {
                            IdCurso = ConvertirAEntero(reader["id_curso"]),
                            NombreCurso = reader["nombre_curso"].ToString(),
                            NumeroInscripciones = inscripciones,
                            FechaInicio = Convert.ToDateTime(reader["fecha_inicio_curso"]),
                            CapacidadMaxima = capacidad,
                            PorcentajeOcupacion = Math.Round(porcentaje, 1)
                        });
                    }
                }
            }

            return cursos;
        }

        private List<EventoProximoDTO> ObtenerProximosEventosDetalle(OracleConnection connection)
        {
            var eventos = new List<EventoProximoDTO>();

            using (var command = new OracleCommand(@"
                SELECT e.id_evento, e.nombre_evento, e.fecha_inicio_evento, e.lugar_evento, 
                       e.capacidad_max_evento, COUNT(ae.id_usuario) as num_asistentes
                FROM Eventos e
                LEFT JOIN Asistencia_evento ae ON e.id_evento = ae.id_evento
                WHERE e.fecha_inicio_evento >= SYSDATE
                GROUP BY e.id_evento, e.nombre_evento, e.fecha_inicio_evento, e.lugar_evento, e.capacidad_max_evento
                ORDER BY e.fecha_inicio_evento ASC
                FETCH FIRST 5 ROWS ONLY", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var fechaInicio = Convert.ToDateTime(reader["fecha_inicio_evento"]);
                        var diasRestantes = (int)(fechaInicio - DateTime.Now).TotalDays;

                        eventos.Add(new EventoProximoDTO
                        {
                            IdEvento = ConvertirAEntero(reader["id_evento"]),
                            NombreEvento = reader["nombre_evento"].ToString(),
                            FechaInicio = fechaInicio,
                            Lugar = reader["lugar_evento"].ToString(),
                            NumeroAsistentes = ConvertirAEntero(reader["num_asistentes"]),
                            CapacidadMaxima = ConvertirAEntero(reader["capacidad_max_evento"]),
                            DiasRestantes = diasRestantes > 0 ? diasRestantes : 0
                        });
                    }
                }
            }

            return eventos;
        }

        private List<UsuarioRecienteDTO> ObtenerUsuariosRecientes(OracleConnection connection)
        {
            var usuarios = new List<UsuarioRecienteDTO>();

            using (var command = new OracleCommand(@"
                SELECT id_usuario, nombre, apellido_paterno, email, fecha_nacimiento, es_miembro, es_administrador
                FROM (
                    SELECT id_usuario, nombre, apellido_paterno, email, fecha_nacimiento, es_miembro, es_administrador
                    FROM Usuarios
                    ORDER BY id_usuario DESC
                )
                WHERE ROWNUM <= 5", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarios.Add(new UsuarioRecienteDTO
                        {
                            IdUsuario = ConvertirAEntero(reader["id_usuario"]),
                            NombreCompleto = $"{reader["nombre"]} {reader["apellido_paterno"]}",
                            Email = reader["email"].ToString(),
                            FechaRegistro = reader["fecha_nacimiento"] != DBNull.Value ?
                                Convert.ToDateTime(reader["fecha_nacimiento"]) : DateTime.MinValue,
                            EsMiembro = reader["es_miembro"].ToString() == "S" ? "Sí" : "No",
                            EsAdministrador = reader["es_administrador"].ToString() == "S" ? "Sí" : "No"
                        });
                    }
                }
            }

            return usuarios;
        }

        private int ConvertirAEntero(object valor)
        {
            if (valor == null || valor == DBNull.Value)
                return 0;

            if (valor is OracleDecimal oracleDecimal)
                return oracleDecimal.ToInt32();

            return Convert.ToInt32(valor);
        }

        public List<EstadisticaMensualDTO> ObtenerInscripcionesPorMes()
        {
            var estadisticas = new List<EstadisticaMensualDTO>();

            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand(@"
                    SELECT EXTRACT(MONTH FROM FECHA_INSCRIPCION_CURSO) as mes,
                           COUNT(*) as cantidad
                    FROM Inscripcion_curso
                    WHERE EXTRACT(YEAR FROM FECHA_INSCRIPCION_CURSO) = EXTRACT(YEAR FROM SYSDATE)
                    GROUP BY EXTRACT(MONTH FROM FECHA_INSCRIPCION_CURSO)
                    ORDER BY mes", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var mes = ConvertirAEntero(reader["mes"]);
                            estadisticas.Add(new EstadisticaMensualDTO
                            {
                                Mes = mes,
                                NombreMes = ObtenerNombreMes(mes),
                                Cantidad = ConvertirAEntero(reader["cantidad"])
                            });
                        }
                    }
                }
            }

            return estadisticas;
        }

        private string ObtenerNombreMes(int mes)
        {
            string[] meses = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return mes >= 1 && mes <= 12 ? meses[mes] : "";
        }
    }
}
