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
        /// <exception cref="FalloBusquedaPacienteException"></exception>
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

                        listaPacientes.Add(paciente);
                    }

                    return listaPacientes;

                }


            }
            catch (Exception ex) 
            {
                throw new FalloBusquedaPacienteException("Error al leer los pacientes de la DB",ex);

            }

        }


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
            catch(Exception)
            {
                throw;
            }
        }

        
        /// <summary>
        /// Devuelve el paciente encontrado por su clave valor
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        /// <exception cref="FalloBusquedaPacienteException"></exception>
        public static Paciente Obtener(string clave,int valor)
        {
            try
            {
                string sentencia = "SELECT * FROM Pacientes WHERE ";
                string columna;

             
                clave.ToLower();

                sentencia += $"{clave} = @{clave}";



                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);

                    command.Parameters.AddWithValue($"{clave}", valor);

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
                        throw new PacienteNoEncontradoException("No se encontro el paciente");
                    }
                    
                    return paciente;

                }


            }
            catch (PacienteNoEncontradoException ex)
            {
                throw ex;
            }
            catch (Exception) 
            {
                throw new FalloBusquedaPacienteException("Error al buscar el paciente");
            }
        }



        /// <summary>
        /// Guarda en la DB un paciente nuevo
        /// </summary>
        /// <param name="paciente"></param>
        /// <exception cref="FalloObtenerPacienteException"></exception>
        public static void Guardar(Paciente paciente)
        {
            try
            {
                string sentencia = "INSERT INTO Pacientes (nombre,apellido,dni,fecha_nacimiento,numero,enEspera,obra_social,historia_clinica,fecha_alta)" +
                    "VALUES (@nombre,@apellido,@dni,@fecha_nacimiento,@numero,@enEspera,@obra_social,@historia_clinica,@fecha_alta)";

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
                    
                    command.Parameters.AddWithValue("fecha_alta", paciente.FechaModificacion);
                    //command.Parameters.AddWithValue("historia_clinica", paciente.HistoriaClinica);                       
                    

                    connection.Open();

                    command.ExecuteNonQuery();

                }
            }
            catch 
            {
                throw new FalloObtenerPacienteException("Error al guardar un paciente");

            }

        }

        /// <summary>
        /// REVISAR
        /// </summary>
        /// <param name="pacienteModificado"></param>
        /// <exception cref="FalloModificarPacienteException"></exception>
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
                    Paciente pacienteOriginal = ADOPacientes.Obtener("id", pacienteModificado.Id);

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
                throw new FalloModificarPacienteException("Error, no pudo modificar el paciente",ex);
            }
        }


        public static void Eliminar(Paciente paciente)
        {
            try
            {
                string sentencia = "DELETE FROM Pacientes WHERE id=@id";

                using (SqlConnection connection = new SqlConnection(ADOPacientes.stringConnection))
                {
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("id", paciente.Id);

                    command.ExecuteNonQuery();
                }


            }
            catch(Exception)
            {
                throw new Exception("No se pudo eliminar el paciente");
            }

        }


    }
}
