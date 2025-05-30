using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Diagnostics;
using System.Data;

namespace DAL
{
    public class CursoRepository
    {
        private readonly ConnectionManager connectionManager;

        public CursoRepository(ConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
        }

        public void Guardar(Curso curso)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Cursos (nombre_curso, descripcion_curso, fecha_inicio_curso, 
                                  fecha_fin_curso, capacidad_max_curso, ruta_imagen_curso, id_administrador) 
                                  VALUES (:nombre_curso, :descripcion_curso, :fecha_inicio_curso, 
                                  :fecha_fin_curso, :capacidad_max_curso, :ruta_imagen_curso, :id_administrador)
                                  RETURNING id_curso INTO :id_curso";

                    command.Parameters.Add(":nombre_curso", OracleDbType.Varchar2).Value = curso.nombre_curso;
                    command.Parameters.Add(":descripcion_curso", OracleDbType.Varchar2).Value = curso.descripcion_curso;
                    command.Parameters.Add(":fecha_inicio_curso", OracleDbType.Date).Value = curso.fecha_inicio_curso;
                    command.Parameters.Add(":fecha_fin_curso", OracleDbType.Date).Value = curso.fecha_fin_curso;
                    command.Parameters.Add(":capacidad_max_curso", OracleDbType.Int32).Value = curso.capacidad_max_curso;
                    command.Parameters.Add(":ruta_imagen_curso", OracleDbType.Varchar2).Value =
                        string.IsNullOrEmpty(curso.ruta_imagen_curso) ? DBNull.Value : (object)curso.ruta_imagen_curso;
                    command.Parameters.Add(":id_administrador", OracleDbType.Int32).Value = curso.id_administrador;

<<<<<<< HEAD
<<<<<<< HEAD
                    // Parámetro de salida para el ID generado
=======
>>>>>>> 6f8011c5a6855480887f32f49b84697d8a357e79
=======
>>>>>>> Abraham
                    OracleParameter idParam = new OracleParameter(":id_curso", OracleDbType.Int32);
                    idParam.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(idParam);

                    command.ExecuteNonQuery();

                    if (idParam.Value is Oracle.ManagedDataAccess.Types.OracleDecimal oracleDecimal)
                    {
                        curso.id_curso = Convert.ToInt32(oracleDecimal.Value);
                    }
                    else if (idParam.Value != DBNull.Value && idParam.Value != null)
                    {
                        curso.id_curso = Convert.ToInt32(idParam.Value);
                    }
                }
            }
        }

        public string ActualizarConProcedimiento(Curso curso)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE_CURSO";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("p_id_curso", OracleDbType.Int32).Value = curso.id_curso;
                    command.Parameters.Add("p_nombre_curso", OracleDbType.Varchar2).Value = curso.nombre_curso ?? (object)DBNull.Value;
                    command.Parameters.Add("p_descripcion_curso", OracleDbType.Varchar2).Value = curso.descripcion_curso ?? (object)DBNull.Value;
                    command.Parameters.Add("p_fecha_inicio_curso", OracleDbType.Date).Value = curso.fecha_inicio_curso;
                    command.Parameters.Add("p_fecha_fin_curso", OracleDbType.Date).Value = curso.fecha_fin_curso;
                    command.Parameters.Add("p_capacidad_max_curso", OracleDbType.Int32).Value = curso.capacidad_max_curso;
                    command.Parameters.Add("p_ruta_imagen_curso", OracleDbType.Varchar2).Value =
                        string.IsNullOrEmpty(curso.ruta_imagen_curso) ? DBNull.Value : (object)curso.ruta_imagen_curso;

                    try
                    {
                        command.ExecuteNonQuery();
                        return $"Curso con ID {curso.id_curso} actualizado exitosamente";
                    }
                    catch (OracleException ex)
                    {
                        if (ex.Number == -20001)
                            return $"Error: {ex.Message}"; // No course found
                        else if (ex.Number == -20002)
                            return $"Error al actualizar el curso: {ex.Message}";
                        else
                            return $"Error inesperado: {ex.Message}";
                    }
                }
            }
        }

        public void Eliminar(int idCurso)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var commandInscripciones = new OracleCommand())
                        {
                            commandInscripciones.Connection = connection;
                            commandInscripciones.Transaction = transaction;
                            commandInscripciones.CommandText = "DELETE FROM INSCRIPCION_CURSO WHERE id_curso = :id_curso";
                            commandInscripciones.Parameters.Add(":id_curso", OracleDbType.Int32).Value = idCurso;
                            commandInscripciones.ExecuteNonQuery();
                        }

                        using (var commandCurso = new OracleCommand())
                        {
                            commandCurso.Connection = connection;
                            commandCurso.Transaction = transaction;
                            commandCurso.CommandText = "DELETE FROM Cursos WHERE id_curso = :id_curso";
                            commandCurso.Parameters.Add(":id_curso", OracleDbType.Int32).Value = idCurso;
                            commandCurso.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al eliminar el curso: " + ex.Message);
                    }
                }
            }
        }

        public int ObtenerIdAdministradorPorUsuario(int idUsuario)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_administrador FROM ADMINISTRADORES WHERE id_usuario = :id_usuario";
                    command.Parameters.Add(":id_usuario", OracleDbType.Int32).Value = idUsuario;

                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("El usuario no es un administrador registrado.");
                }
            }
        }

        public Curso BuscarPorId(int idCurso)
        {
            Curso curso = null;
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cursos WHERE id_curso = :id_curso";

                    command.Parameters.Add(":id_curso", OracleDbType.Int32).Value = idCurso;

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            curso = MapToCurso(reader);
                        }
                    }
                }
            }
            return curso;
        }

        public List<Curso> ConsultarTodos()
        {
            List<Curso> cursos = new List<Curso>();
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cursos";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Curso curso = MapToCurso(reader);
                            cursos.Add(curso);
                        }
                    }
                }
            }
            return cursos;
        }

        public List<Curso> ConsultarCursosDisponibles()
        {
            List<Curso> cursos = new List<Curso>();
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Cursos WHERE fecha_fin_curso >= :fecha_actual";

                    command.Parameters.Add(":fecha_actual", OracleDbType.Date).Value = DateTime.Now;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Curso curso = MapToCurso(reader);
                            cursos.Add(curso);
                        }
                    }
                }
            }
            return cursos;
        }

        private Curso MapToCurso(OracleDataReader reader)
        {
            return new Curso
            {
                id_curso = Convert.ToInt32(reader["id_curso"]),
                nombre_curso = reader["nombre_curso"].ToString(),
                descripcion_curso = reader["descripcion_curso"].ToString(),
                fecha_inicio_curso = Convert.ToDateTime(reader["fecha_inicio_curso"]),
                fecha_fin_curso = Convert.ToDateTime(reader["fecha_fin_curso"]),
                capacidad_max_curso = Convert.ToInt32(reader["capacidad_max_curso"]),
                ruta_imagen_curso = reader["ruta_imagen_curso"] != DBNull.Value ? reader["ruta_imagen_curso"].ToString() : null,
                id_administrador = reader["id_administrador"] != DBNull.Value ? Convert.ToInt32(reader["id_administrador"]) : 0
            };
        }
    }
}