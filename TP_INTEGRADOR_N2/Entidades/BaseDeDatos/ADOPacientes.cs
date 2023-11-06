using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Entidades.Excepciones;

namespace Entidades.BaseDeDatos
{
    public static class ADOPacientes
    {
        private static string stringConnection;

        static ADOPacientes() 
        {
            ADOPacientes.stringConnection = "Server = .; Database = CentroMedicoTP; Trusted_Connection = True;";
            
        }
        
        /// <summary>
        /// Obtiene una lista del total de pacientes almacenados en la DB
        /// </summary>
        /// <returns></returns>
        /// <exception cref="LecturaPacienteExcepcion"></exception>
        public static List<Paciente> ObtenerPacientesTotales()
        {

            try
            {
                string sentencia = "SELECT * FROM Pacientes";
                List<Paciente> listaPacientes = new List<Paciente>();

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) 
                    {
                        //ACA APLICO LA LOGICA SEGUN LAS COLUMNAS, ME FALTA CREAR LA DB
                        Paciente paciente = new Paciente();
                        paciente.Id = reader.GetInt32(0);
                        paciente.Nombre = reader.GetString(1);
                        paciente.Apellido = reader.GetString(2);
                        paciente.Dni = reader.GetInt32(3);
                        paciente.FechaNacimiento = reader.GetDateTime(4);
                        paciente.NumeroAfiliado = reader.GetInt64(5);
                        paciente.Atendido = reader.GetBoolean(6);
                        
                        if (Enum.TryParse(reader.GetString(7), out EObrasSocial obraSocial))
                        {
                            paciente.ObraSocial = obraSocial;
                        }
                        else
                        {
                            //ACA LANZAR UNA EXPCECION
                        }

                        paciente.HistoriaClinica = reader.GetString(8);

                        listaPacientes.Add(paciente);
                    }

                }

                return listaPacientes;

            }
            catch 
            {
                throw new LecturaPacienteExcepcion("Error al leer los pacientes de la DB");

            }

        }


        /// <summary>
        /// Obtiene una lista del total de pacientes atendidos o sin atender, bajo una condicion por parametros
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="booleano">1=true o 0=false</param>
        /// <exception cref="IntentoDeAlmacenarPacienteException"></exception>
        public static List<Paciente> ObtenerPacientesTotales(int booleano)
        {
            try
            {
                string sentencia = "SELECT * FROM Pacientes WHERE atendido = @atendido";
                List<Paciente> listaPacientes = new List<Paciente>();

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("atendido", booleano);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        //ACA APLICO LA LOGICA SEGUN LAS COLUMNAS, ME FALTA CREAR LA DB
                        Paciente paciente = new Paciente();
                        paciente.Id = reader.GetInt32(0);
                        paciente.Nombre = reader.GetString(1);
                        paciente.Apellido = reader.GetString(2);
                        paciente.Dni = reader.GetInt32(3);
                        paciente.FechaNacimiento = reader.GetDateTime(4);
                        paciente.NumeroAfiliado = reader.GetInt64(5);
                        paciente.Atendido = reader.GetBoolean(6);

                        if (Enum.TryParse(reader.GetString(7), out EObrasSocial obraSocial))
                        {
                            paciente.ObraSocial = obraSocial;
                        }
                        else
                        {
                            throw new IntentoDeAlmacenarPacienteException("Error al internar obtener pacientes de DB");
                        }

                        paciente.HistoriaClinica = reader.GetString(8);

                        listaPacientes.Add(paciente);
                    }

                }

                return listaPacientes;

            }
            catch
            {
                throw new LecturaPacienteExcepcion("Error al leer los pacientes de la DB");

            }

        }
        /// <summary>
        /// Guarda en la DB un paciente nuevo
        /// </summary>
        /// <param name="paciente"></param>
        /// <exception cref="IntentoDeAlmacenarPacienteException"></exception>
        public static void Guardar(Paciente paciente)
        {
            try
            {
                string sentencia = "INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,atendido,obra_social)" +
                    "VALUES (@nombre,@apellido,@dni,@fecha_nacimiento,@numero,@atendido,@obra_social)";

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("nombre", paciente.Nombre);
                    command.Parameters.AddWithValue("apellido", paciente.Apellido);
                    command.Parameters.AddWithValue("dni", paciente.Dni);
                    command.Parameters.AddWithValue("fecha_nacimiento", paciente.FechaNacimiento);
                    command.Parameters.AddWithValue("numero", paciente.NumeroAfiliado);
                    command.Parameters.AddWithValue("atendido", paciente.Atendido);
                    command.Parameters.AddWithValue("obra_social", paciente.ObraSocial.ToString());                   
                    //command.Parameters.AddWithValue("historia_clinica", paciente.HistoriaClinica);                       
                    

                    connection.Open();

                    command.ExecuteNonQuery();

                }
            }
            catch 
            {
                throw new IntentoDeAlmacenarPacienteException("Error al guardar un paciente");

            }

        }
    }
}
