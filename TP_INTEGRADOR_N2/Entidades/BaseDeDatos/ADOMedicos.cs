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
        /// <exception cref="LecturaRegistrosExcepcion"></exception>
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
            catch
            {
                throw new LecturaRegistrosExcepcion("Error al leer los medicos de la DB");

            }

        }


        /// <summary>
        /// Obtiene un medico de DB por su ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Un objeto del tipo Medico</returns>
        /// <exception cref="LecturaRegistrosExcepcion"></exception>
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
            catch (Exception ex)            
            {
                throw new LecturaRegistrosExcepcion("Error al obtener el medico por su ID");
            
            }
            
            
            
            


        }

        public static void Guardar(Medico medico)
        {
            try
            {
                string sentencia = "INSERT INTO Medicos (nombre,apellido,dni,fecha_nacimiento,matricula,especialidad)" +
                    "VALUES (@nombre,@apellido,@dni,@fecha_nacimiento,@matricula,@especialidad)";

                using (SqlConnection connection = new SqlConnection(ADOMedicos.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("nombre", medico.Nombre);
                    command.Parameters.AddWithValue("apellido", medico.Apellido);
                    command.Parameters.AddWithValue("dni", medico.Dni);
                    command.Parameters.AddWithValue("fecha_nacimiento", medico.FechaNacimiento);
                    command.Parameters.AddWithValue("matricula", medico.NumeroMatricula);
                    command.Parameters.AddWithValue("especialidad", medico.Especialidad.ToString());

                    connection.Open();

                    command.ExecuteNonQuery();


                }


            }
            catch
            {
                throw new InvalidOperationException("Error al guardar el medico en la DB");

            }


        }
    }
}
