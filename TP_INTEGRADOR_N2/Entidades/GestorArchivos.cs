using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorArchivos<T> where T : class
    {
        private string rutaArchivo;
        private string objetoSerializado;
        private List<T> registros;

        public GestorArchivos(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
        }

        public GestorArchivos(string rutaArchivo, List<T> registros):this(rutaArchivo)
        {
            this.registros = registros;
        }

        public string ObjetoDeserializado
        {
            get { return objetoSerializado; }
        }

        public List<T> Registros
        {
            get { return this.registros; }
        }

        /// <summary>
        /// Exporta una cadena en formato de archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <exception cref="Exception"></exception>
        public void Exportar(string archivo)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.rutaArchivo))
                {
                   streamWriter.Write(archivo);
                }

            }
            catch (Exception ex) 
            {
                throw new Exception("Error al guardar el archivo", ex);
            }
        }

        /// <summary>
        /// Exporta una lista serializada
        /// </summary>
        public void Exportar()
        {
            try
            {          
                if (this.objetoSerializado is not null)
                {
                    this.Exportar(this.objetoSerializado);
                }
                
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Serializa el objeto
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void Serializar()
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                //guardo el objeto serializado en mi atributo
                this.objetoSerializado = JsonSerializer.Serialize(this.registros,options);

            }
            catch(Exception ex)
            {
                throw new Exception("Error al serializar el objeto", ex);
            }
        }

        /// <summary>
        /// Deserializa un archivo
        /// </summary>
        public void Deserializar()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(this.rutaArchivo))
                {
                    string archivoLeido = streamReader.ReadToEnd();
                    this.registros = JsonSerializer.Deserialize<List<T>>(archivoLeido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo",ex);
            }
        }

    }
}
