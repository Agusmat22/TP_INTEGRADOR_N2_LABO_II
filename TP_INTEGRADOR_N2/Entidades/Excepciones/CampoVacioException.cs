using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    /// <summary>
    /// Cuando un campo de un elemento de .net se encuentre vacio
    /// </summary>
    public class CampoVacioException : Exception
    {

        public CampoVacioException(string message):base(message) 
        { 
        
        }

        public CampoVacioException(string message,Exception excepcion) : base(message,excepcion)
        {

        }
    }
}
