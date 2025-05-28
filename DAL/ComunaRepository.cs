using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class ComunaRepository
    {
        private readonly ConnectionManager connectionManager;

        public ComunaRepository(ConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
        }

        public void Guardar(Comuna comuna)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Comunas (nombre_comuna) 
                                          VALUES (:nombre_comuna)
                                          RETURNING id_comuna INTO :id_comuna";

                    command.Parameters.Add(":nombre_comuna", OracleDbType.Varchar2).Value = comuna.nombre_comuna;

                    // Parámetro de salida para el ID generado
                    OracleParameter idParam = new OracleParameter(":id_comuna", OracleDbType.Int32);
                    idParam.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(idParam);

                    command.ExecuteNonQuery();
                    comuna.id_comuna = Convert.ToInt32(idParam.Value);
                }
            }
        }

        public void Modificar(Comuna comuna)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Comunas SET nombre_comuna = :nombre_comuna 
                                          WHERE id_comuna = :id_comuna";

                    command.Parameters.Add(":id_comuna", OracleDbType.Int32).Value = comuna.id_comuna;
                    command.Parameters.Add(":nombre_comuna", OracleDbType.Varchar2).Value = comuna.nombre_comuna;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int idComuna)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Comunas WHERE id_comuna = :id_comuna";

                    command.Parameters.Add(":id_comuna", OracleDbType.Int32).Value = idComuna;

                    command.ExecuteNonQuery();
                }
            }
        }

        public Comuna BuscarPorId(int idComuna)
        {
            Comuna comuna = null;
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Comunas WHERE id_comuna = :id_comuna";

                    command.Parameters.Add(":id_comuna", OracleDbType.Int32).Value = idComuna;

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comuna = MapToComuna(reader);
                        }
                    }
                }
            }
            return comuna;
        }

        public List<Comuna> ConsultarTodas()
        {
            List<Comuna> comunas = new List<Comuna>();
            using (var connection = connectionManager.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Comunas ORDER BY nombre_comuna";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comuna comuna = MapToComuna(reader);
                            comunas.Add(comuna);
                        }
                    }
                }
            }
            return comunas;
        }

        private Comuna MapToComuna(OracleDataReader reader)
        {
            return new Comuna
            {
                id_comuna = Convert.ToInt32(reader["id_comuna"]),
                nombre_comuna = reader["nombre_comuna"].ToString()
            };
        }
    }
}