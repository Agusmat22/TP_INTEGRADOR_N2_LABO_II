using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorArchivos<T>
    {
        private string rutaArchivo;
        private string objetoSerializado;
        private List<T> registros;

        public GestorArchivos(string rutaArchivo, List<T> registros)
        {
            this.rutaArchivo = rutaArchivo;
            this.registros = registros;
        }

        /// <summary>
        /// Almacena el archivo pasado por parametros
        /// </summary>
        /// <param name="archivo"></param>
        /// <exception cref="Exception"></exception>
        public void GuardarArchivo(string archivo)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.rutaArchivo))
                {
                   streamWriter.Write(archivo);
                }

            }
            catch (Exception) 
            {
                throw new Exception("Error al guardar el archivo");
            }
        }

        /// <summary>
        /// Almacena el objeto serializado
        /// </summary>
        public void GuardarArchivo()
        {
            try
            {          
                if (this.objetoSerializado is not null)
                {
                    this.GuardarArchivo(this.objetoSerializado);
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
        /// <exception cref="NotSupportedException"></exception>
        public void SerializarObjeto()
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                //guardo el objeto serializado en mi atributo
                this.objetoSerializado = JsonSerializer.Serialize(this.registros,options);

            }
            catch(NotSupportedException ex)
            {
                throw new NotSupportedException("Error al serializar el objeto", ex);
            }
        }

    }
}
