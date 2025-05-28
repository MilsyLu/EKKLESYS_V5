using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class AsistenciaEventoRepository
    {
        private readonly ConnectionManager connectionManager;
        private readonly UsuarioRepository usuarioRepository;

        public AsistenciaEventoRepository(ConnectionManager connectionManager, UsuarioRepository usuarioRepository)
        {
            this.connectionManager = connectionManager;
            this.usuarioRepository = usuarioRepository;
        }

        public void Guardar(Asistencia_evento asistencia)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;

                    // Usar el nombre correcto de la columna: FECHA_ASISTENCIA_EVENTO
                    command.CommandText = @"INSERT INTO Asistencia_evento (id_usuario, id_evento, FECHA_ASISTENCIA_EVENTO) 
                                  VALUES (:id_usuario, :id_evento, :fecha_asistencia)";

                    command.Parameters.Add(":id_usuario", OracleDbType.Int32).Value = asistencia.id_usuario;
                    command.Parameters.Add(":id_evento", OracleDbType.Int32).Value = asistencia.id_evento;

                    // Si tienes la fecha en tu objeto, úsala; de lo contrario, puedes omitirla ya que tiene SYSDATE como valor predeterminado
                    if (asistencia.fecha_asistencia_evento != default(DateTime))
                    {
                        command.Parameters.Add(":fecha_asistencia", OracleDbType.Date).Value = asistencia.fecha_asistencia_evento;
                    }
                    else
                    {
                        // Usar SYSDATE de Oracle
                        command.Parameters.Add(":fecha_asistencia", OracleDbType.Date).Value = null;
                    }

                    command.ExecuteNonQuery();

                    // Si necesitas obtener el ID generado
                    command.CommandText = "SELECT SEQ_ASISTENCIA_EVENTO.CURRVAL FROM dual";

                    // Manejar correctamente la conversión de OracleDecimal
                    var result = command.ExecuteScalar();
                    if (result is Oracle.ManagedDataAccess.Types.OracleDecimal oracleDecimal)
                    {
                        asistencia.id_asistencia = Convert.ToInt32(oracleDecimal.Value);
                    }
                    else if (result != null && result != DBNull.Value)
                    {
                        asistencia.id_asistencia = Convert.ToInt32(result);
                    }
                }
            }
        }


        //public void Guardar(Asistencia_evento asistencia)
        //{
        //    using (var connection = connectionManager.GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new OracleCommand())
        //        {
        //            command.Connection = connection;

        //            // Primero, insertar el registro
        //            command.CommandText = @"INSERT INTO Asistencia_evento (id_usuario, id_evento, fecha_asistencia_evento) 
        //                          VALUES (:id_usuario, :id_evento, :fecha_registro)";

        //            command.Parameters.Add(":id_usuario", OracleDbType.Int32).Value = asistencia.id_usuario;
        //            command.Parameters.Add(":id_evento", OracleDbType.Int32).Value = asistencia.id_evento;
        //            command.Parameters.Add(":fecha_asistencia_evento", OracleDbType.Date).Value = asistencia.fecha_asistencia_evento;

        //            command.ExecuteNonQuery();

        //            // Luego, obtener el ID generado (si es necesario)
        //            command.CommandText = "SELECT SEQ_ASISTENCIA_EVENTO.CURRVAL FROM dual";
        //            asistencia.id_asistencia = Convert.ToInt32(command.ExecuteScalar());
        //        }
        //    }
        //}

        //public void Guardar(Asistencia_evento asistencia)
        //{
        //    using (var connection = connectionManager.GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new OracleCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = @"INSERT INTO Asistencia_evento (id_usuario, id_evento, fecha_registro) 
        //                                  VALUES (@id_usuario, @id_evento, @fecha_registro);
        //                                  SELECT SCOPE_IDENTITY()";

        //            command.Parameters.Add("@id_usuario", asistencia.id_usuario);
        //            command.Parameters.Add("@id_evento", asistencia.id_evento);
        //            command.Parameters.Add("@fecha_registro", asistencia.fecha_registro);

        //            asistencia.id_asistencia = Convert.ToInt32(command.ExecuteScalar());
        //        }
        //    }
        //}

        public void Eliminar(int idUsuario, int idEvento)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Asistencia_evento WHERE id_usuario = :id_usuario AND id_evento = :id_evento";

                    command.Parameters.Add(":id_usuario", OracleDbType.Int32).Value = idUsuario;
                    command.Parameters.Add(":id_evento", OracleDbType.Int32).Value = idEvento;

                    command.ExecuteNonQuery();
                }
            }
        }

        //public void Eliminar(int idUsuario, int idEvento)
        //{
        //    using (var connection = connectionManager.GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new OracleCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "DELETE FROM Asistencia_evento WHERE id_usuario = @id_usuario AND id_evento = @id_evento";

        //            command.Parameters.Add("@id_usuario", idUsuario);
        //            command.Parameters.Add("@id_evento", idEvento);

        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public bool ExisteAsistencia(int idUsuario, int idEvento)
        {
            bool existe = false;
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Asistencia_evento WHERE id_usuario = :id_usuario AND id_evento = :id_evento";

                    command.Parameters.Add(":id_usuario", OracleDbType.Int32).Value = idUsuario;
                    command.Parameters.Add(":id_evento", OracleDbType.Int32).Value = idEvento;

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    existe = count > 0;
                }
            }
            return existe;
        }

        //public bool ExisteAsistencia(int idUsuario, int idEvento)
        //{
        //    bool existe = false;
        //    using (var connection = connectionManager.GetConnection())
        //    {
        //        connection.Open();
        //        using (var command = new OracleCommand())
        //        {
        //            command.Connection = connection;
        //            command.CommandText = "SELECT COUNT(*) FROM Asistencia_evento WHERE id_usuario = @id_usuario AND id_evento = @id_evento";

        //            command.Parameters.Add("@id_usuario", idUsuario);
        //            command.Parameters.Add("@id_evento", idEvento);

        //            int count = Convert.ToInt32(command.ExecuteScalar());
        //            existe = count > 0;
        //        }
        //    }
        //    return existe;
        //}

        public List<Usuario> ConsultarAsistentesPorEvento(int idEvento)
        {
            List<Usuario> asistentes = new List<Usuario>();
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_usuario FROM Asistencia_evento WHERE id_evento = :id_evento";

                    command.Parameters.Add("id_evento", idEvento);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idUsuario = Convert.ToInt32(reader["id_usuario"]);
                            Usuario usuario = usuarioRepository.BuscarPorId(idUsuario);
                            if (usuario != null)
                            {
                                asistentes.Add(usuario);
                            }
                        }
                    }
                }
            }
            return asistentes;
        }

        public List<Evento> ConsultarEventosPorUsuario(int idUsuario, EventoRepository eventoRepository)
        {
            List<Evento> eventos = new List<Evento>();
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT id_evento FROM Asistencia_evento WHERE id_usuario = :id_usuario";

                    command.Parameters.Add("id_usuario", idUsuario);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idEvento = Convert.ToInt32(reader["id_evento"]);
                            Evento evento = eventoRepository.BuscarPorId(idEvento);
                            if (evento != null)
                            {
                                eventos.Add(evento);
                            }
                        }
                    }
                }
            }
            return eventos;
        }
    }
}
