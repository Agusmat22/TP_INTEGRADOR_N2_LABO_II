using Entidades.Excepciones;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BaseDeDatos
{
    public class ADOMedicos
    {
        private static string stringConnection;

        static ADOMedicos()
        {
            ADOMedicos.stringConnection = "Server = .; Database = CentroMedicoTP; Trusted_Connection = True;";

        }

        /// <summary>
        /// Obtiene todos los medicos de la DB
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Medico> ObtenerMedicosTotales()
        {

            try
            {
                string sentencia = "SELECT * FROM Medicos";
                List<Medico> listaMedicos = new List<Medico>();

                using (SqlConnection connection = new SqlConnection(ADOMedicos.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //ACA APLICO LA LOGICA SEGUN LAS COLUMNAS, ME FALTA CREAR LA DB
                        Medico medico = new Medico();

                        medico.Id = reader.GetInt32(0);
                        medico.Nombre = reader.GetString(1);
                        medico.Apellido = reader.GetString(2);
                        medico.Dni = reader.GetInt32(3);
                        medico.FechaNacimiento = reader.GetDateTime(4);
                        medico.NumeroMatricula = reader.GetInt64(5);
                        

                        if (Enum.TryParse(reader.GetString(6), out EEspecialidad especialidad))
                        {
                            medico.Especialidad = especialidad;
                        }
                        else
                        {
                            //ACA LANZAR UNA EXPCECION
                        }

                        listaMedicos.Add(medico);
                    }

                }

                return listaMedicos;

            }
            catch(Exception ex)
            {
                throw new Exception("Error al obtener los medicos de la base de datos",ex);

            }

        }

        /*
        /// <summary>
        /// Obtiene un medico de DB por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un objeto del tipo Medico</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public static Medico ObtenerMedicoPorId(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Medicos WHERE id_medico=@id_medico";

                using (SqlConnection connection = new SqlConnection())
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("id_medico", id);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) 
                    { 
                        Medico medico = new Medico();

                        medico.Id = reader.GetInt32(0);
                        medico.Nombre = reader.GetString(1);
                        medico.Apellido = reader.GetString(2);
                        medico.Dni = reader.GetInt32(3);
                        medico.FechaNacimiento = reader.GetDateTime(4);
                        medico.NumeroMatricula = reader.GetInt64(5);

                        if (Enum.TryParse(reader.GetString(6), out EEspecialidad especialidad))
                        {
                            medico.Especialidad = especialidad;                          
                        }

                        return medico;
                    }

                    throw new ArgumentNullException("No se encontro el medico");
                }
            }
            catch (ArgumentNullException)            
            {
                throw;          
            }
            catch(Exception)
            {
                throw;
            }

        }

        */
        /// <summary>
        /// Guarda un medico en la DB
        /// </summary>
        /// <param name="medico"></param>
        /// <exception cref="FalloGuardarRegistroException"></exception>
        public static void Guardar(Medico medico)
        {
            try
            {
                string sentencia = "INSERT INTO Medicos (nombre,apellido,dni,fecha_nacimiento,matricula,especialidad,fecha_modificacion)" +
                    "VALUES (@nombre,@apellido,@dni,@fecha_nacimiento,@matricula,@especialidad,@fecha_modificacion)";

                using (SqlConnection connection = new SqlConnection(ADOMedicos.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("nombre", medico.Nombre);
                    command.Parameters.AddWithValue("apellido", medico.Apellido);
                    command.Parameters.AddWithValue("dni", medico.Dni);
                    command.Parameters.AddWithValue("fecha_nacimiento", medico.FechaNacimiento);
                    command.Parameters.AddWithValue("matricula", medico.NumeroMatricula);
                    command.Parameters.AddWithValue("especialidad", medico.Especialidad.ToString());
                    command.Parameters.AddWithValue("fecha_modificacion", medico.FechaModificacion);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new FalloGuardarRegistroException("Error al guardar el medico en la DB");
            }

        }

        /// <summary>
        /// Elimina un medico de la base de datos
        /// </summary>
        /// <param name="medico"></param>
        /// <exception cref="Exception"></exception>
        public static void Eliminar(Medico medico)
        {
            try
            {
                string sentencia = "DELETE FROM Medicos WHERE id_medico=@id_medico";

                using (SqlConnection connection = new SqlConnection(ADOMedicos.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("id_medico", medico.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al eliminar el medico en la base de datos",ex);
            }
        }
    }
}
