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
        private static DateTime fechaComparacion;

        static ADOPacientes() 
        {
            ADOPacientes.stringConnection = "Server = .; Database = CentroMedicoTP; Trusted_Connection = True;";
            ADOPacientes.fechaComparacion = DateTime.Now;
        }

        /// <summary>
        /// Obtiene una lista del total de pacientes almacenados en la DB
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Paciente> ObtenerLista()
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
                        paciente.EnEspera = reader.GetBoolean(6);
                        
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

                        paciente.FechaModificacion = reader.GetDateTime(9);


                        listaPacientes.Add(paciente);
                    }

                    return listaPacientes;

                }


            }
            catch (Exception ex) 
            {
                throw new Exception("Error al leer los pacientes de la DB",ex);

            }

        }

        /// <summary>
        /// Obtiene pacientes que hayan sido modificados recientemente
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Paciente> ObtenerModificados()
        {
            try
            {
                string sentencia = "SELECT * FROM Pacientes WHERE fecha_modificacion > @fecha_modificacion";


                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("fecha_modificacion",ADOPacientes.fechaComparacion);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Paciente> listaPacientes = new List<Paciente>();

                    //AGREGAR UN IF DONDE VALIDE SI CONTIENE FILAS Y SINO LANZAR UNA EXCEPCION
                    if(reader.HasRows)
                    {
                        ADOPacientes.fechaComparacion = DateTime.Now;
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
                            paciente.EnEspera = reader.GetBoolean(6);

                            if (Enum.TryParse(reader.GetString(7), out EObrasSocial obraSocial))
                            {
                                paciente.ObraSocial = obraSocial;
                            }
                            else
                            {
                                //ACA LANZAR UNA EXPCECION
                            }

                            //valido que no sea nulo, ya que la historia clinica puede serlo
                            if (!reader.IsDBNull(8))
                            {
                                paciente.HistoriaClinica = reader.GetString(8);
                            }

                            //ACA ESTABA EL ERROR
                            paciente.FechaModificacion = reader.GetDateTime(9);

                            listaPacientes.Add(paciente);
                        }

                        return listaPacientes;
                    }
                    else
                    {
                        //LANZO UNA EXCEPCION
                        return null;
                    }
                   
                }




            }
            catch(Exception ex)
            {
                throw new Exception("Error al guardar el paciente modificado en la base de datos",ex);
            }
        }

        

        /// <summary>
        /// Obtiene un paciente de la DB por su ID
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// <exception cref="FalloBusquedaPacienteException"></exception>
        public static Paciente Obtener(int id)
        {
            try
            {
                string sentencia = "SELECT * FROM Pacientes WHERE id=@id ";
                string columna;
            
                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);

                    command.Parameters.AddWithValue("id", id);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    Paciente paciente = new Paciente();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            paciente.Id = reader.GetInt32(0);
                            paciente.Nombre = reader.GetString(1);
                            paciente.Apellido = reader.GetString(2);
                            paciente.Dni = reader.GetInt32(3);
                            paciente.FechaNacimiento = reader.GetDateTime(4);
                            paciente.NumeroAfiliado = reader.GetInt64(5);
                            paciente.EnEspera = reader.GetBoolean(6);

                            if (Enum.TryParse(reader.GetString(7), out EObrasSocial obraSocial))
                            {
                                paciente.ObraSocial = obraSocial;
                            }


                            //valido que la historial clinica no sea null, por parametro le paso la posicion de la columna
                            if (!reader.IsDBNull(8))
                            {
                                paciente.HistoriaClinica = reader.GetString(8);
                            }

                            paciente.FechaModificacion = reader.GetDateTime(9);

                        }
                    }
                    else
                    {
                        throw new ArgumentNullException("No se encontro el paciente");
                    }
                    
                    return paciente;

                }


            }
            catch (ArgumentNullException)
            {
                throw;
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al obtener paciente de la base de datos",ex);
            }
        }



        /// <summary>
        /// Guarda en la DB un paciente nuevo que no exista
        /// </summary>
        /// <param name="paciente"></param>
        /// <exception cref="FalloGuardarRegistroException"></exception>
        public static void Guardar(Paciente paciente)
        {
            try
            {
                //VALIDO QUE NO EXISTA EL PACIENTE CON EL NUMERO DE AFILIADO
                string sentencia = "IF NOT EXISTS(SELECT numero FROM Pacientes WHERE numero=@numero)" +
                    "INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,historia_clinica,fecha_modificacion)" +
                    "VALUES (@nombre,@apellido,@dni,@fecha_nacimiento,@numero,@enEspera,@obra_social,@historia_clinica,@fecha_modificacion)";

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {

                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("nombre", paciente.Nombre);
                    command.Parameters.AddWithValue("apellido", paciente.Apellido);
                    command.Parameters.AddWithValue("dni", paciente.Dni);
                    command.Parameters.AddWithValue("fecha_nacimiento", paciente.FechaNacimiento);
                    command.Parameters.AddWithValue("numero", paciente.NumeroAfiliado);
                    command.Parameters.AddWithValue("enEspera", paciente.EnEspera);
                    command.Parameters.AddWithValue("obra_social", paciente.ObraSocial.ToString());

                    //PREGUNTAR AL PROFE
                    command.Parameters.AddWithValue("historia_clinica", paciente.HistoriaClinica ?? (object)DBNull.Value);
                    
                    command.Parameters.AddWithValue("fecha_modificacion", paciente.FechaModificacion);
                    //command.Parameters.AddWithValue("historia_clinica", paciente.HistoriaClinica);                       
                    

                    connection.Open();

                    //valido las filas afectadas para saber si lo guardo o no
                    int cantidadDeFilasAfectadas = command.ExecuteNonQuery();

                    if (cantidadDeFilasAfectadas == -1)
                    {
                        throw new FalloGuardarRegistroException("No se pudo guardar el paciente ya que existen registros con el mismo numerod de afiliado");
                    }

                }
            }
            catch(FalloGuardarRegistroException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al intertar guardar el paciente en la base de datos",ex);
            }
           

        }

        /// <summary>
        /// GUARDA UN PACIENTE MODIFICADO EN LA BASE DE DATOS
        /// </summary>
        /// <param name="pacienteModificado"></param>
        /// <exception cref="FalloModificarRegistroException"></exception>
        public static void Modificar(Paciente pacienteModificado)
        {
            try
            {
                string sentencia = "UPDATE Pacientes SET ";
                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;

                    //OBTENGO EL PACIENTE DE LA DB PARA BUSCAR LAS DIFERENCIAS Y MODIFICARLO
                    Paciente pacienteOriginal = ADOPacientes.Obtener(pacienteModificado.Id);

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

                        if (pacienteModificado.EnEspera != pacienteOriginal.EnEspera)
                        {
                            sentencia += "enEspera = @enEspera, ";
                            command.Parameters.AddWithValue("enEspera", pacienteModificado.EnEspera);
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
                        

                        sentencia += "fecha_modificacion = @fecha_modificacion, ";
                        command.Parameters.AddWithValue("fecha_modificacion", DateTime.Now);
                        //elimino la coma final y el espacio
                        sentencia = sentencia.TrimEnd(',',' ');

                        //le agrego un espacio para que quede mas prolijo
                        sentencia += " WHERE id=@id";
                        command.Parameters.AddWithValue("id", pacienteModificado.Id);

                        //le asigno la sentencia
                        command.CommandText = sentencia;

                        //abro la coneccion
                        connection.Open();

                        //ejecuto el comando 
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex) 
            {            
                throw new FalloModificarRegistroException("Error, no pudo modificar el paciente en la BASE DE DATOS",ex);
            }
        }

        /// <summary>
        /// Elimina un paciente de la base de datos
        /// </summary>
        /// <param name="paciente"></param>
        /// <exception cref="Exception"></exception>
        public static void Eliminar(Paciente paciente)
        {
            try
            {
                string sentencia = "DELETE FROM Pacientes WHERE id=@id";

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("id", paciente.Id);
                    connection.Open();

                    command.ExecuteNonQuery();
                }


            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo eliminar el paciente en la base de datos",ex);
            }

        }


    }
}
