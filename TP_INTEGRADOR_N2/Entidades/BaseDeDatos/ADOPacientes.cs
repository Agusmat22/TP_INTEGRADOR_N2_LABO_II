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
        /// <exception cref="LecturaRegistrosExcepcion"></exception>
        public static List<Paciente> ObtenerPacientesTotales()
        {

            try
            {
                string sentencia = "SELECT * FROM Pacientes";

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    List<Paciente> listaPacientes = new List<Paciente>();

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

                        //valido que no sea nulo, ya que la historia clinica puede serlo
                        if(!reader.IsDBNull(8))
                        {
                            paciente.HistoriaClinica = reader.GetString(8);
                        }

                        listaPacientes.Add(paciente);
                    }

                    return listaPacientes;

                }


            }
            catch (Exception ex) 
            {
                throw new LecturaRegistrosExcepcion("Error al leer los pacientes de la DB",ex);

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

                        //valido que la historial clinica no sea null, por parametro le paso la posicion de la columna
                        if (!reader.IsDBNull(8))
                        {
                            paciente.HistoriaClinica = reader.GetString(8);
                        }

                        listaPacientes.Add(paciente);
                    }

                }

                return listaPacientes;

            }
            catch
            {
                throw new LecturaRegistrosExcepcion("Error al leer los pacientes de la DB");

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


        public static void Modificar(Paciente pacienteModificado,Paciente pacienteOriginal)
        {
            try
            {
                string sentencia = "UPDATE Pacientes SET ";
                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    //De esta manera hago mas eficiente y no arbitrariamente debo actualizar todas las columnas
                    if (pacienteModificado == pacienteOriginal)
                    {
                        if (pacienteModificado.Nombre != pacienteOriginal.Nombre)
                        {
                            sentencia += "nombre = @nombre, ";
                            command.Parameters.AddWithValue("nombre", pacienteModificado.Nombre);
                        }

                        if (pacienteModificado.Apellido != pacienteOriginal.Apellido)
                        {
                            sentencia += "apellido = @apellido, ";
                            command.Parameters.AddWithValue("apellido", pacienteModificado.Apellido);
                        }

                        if (pacienteModificado.Dni != pacienteOriginal.Dni)
                        {
                            sentencia += "dni = @dni, ";
                            command.Parameters.AddWithValue("dni", pacienteModificado.Dni);
                        }

                        if (pacienteModificado.FechaNacimiento != pacienteOriginal.FechaNacimiento)
                        {
                            sentencia += "fecha_nacimiento = @fecha_nacimiento, ";
                            command.Parameters.AddWithValue("fecha_nacimiento", pacienteModificado.FechaNacimiento);
                        }

                        if (pacienteModificado.NumeroAfiliado != pacienteOriginal.NumeroAfiliado)
                        {
                            sentencia += "numero = @numero, ";
                            command.Parameters.AddWithValue("numero", pacienteModificado.NumeroAfiliado);
                        }

                        if (pacienteModificado.Atendido != pacienteOriginal.Atendido)
                        {
                            sentencia += "atendido = @atendido, ";
                            command.Parameters.AddWithValue("atendido", pacienteModificado.NumeroAfiliado);
                        }

                        if (pacienteModificado.ObraSocial != pacienteOriginal.ObraSocial)
                        {
                            sentencia += "obra_social = @obra_social, ";
                            command.Parameters.AddWithValue("obra_social", pacienteModificado.ObraSocial.ToString());
                        }

                        if (pacienteModificado.HistoriaClinica != pacienteOriginal.HistoriaClinica)
                        {
                            sentencia += "historia_clinica = @historia_clinica, ";
                            command.Parameters.AddWithValue("historia_clinica", pacienteModificado.HistoriaClinica);
                        }

                        //elimino la , final y el espacio
                        sentencia.TrimEnd(',');

                        sentencia += "WHERE id=@id";
                        command.Parameters.AddWithValue("id", pacienteModificado.Id);

                        //le asigno la sentencia
                        command.CommandText = sentencia;

                        //ejecuto el comando 
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex) 
            { 
            
                throw ex;
            }



        }
    }
}
