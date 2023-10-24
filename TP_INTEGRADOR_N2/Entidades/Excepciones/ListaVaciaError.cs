using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    /// <summary>
    /// Esta excepcion sera utilizada cuando una lista este vacia
    /// </summary>
    public class ListaVaciaError : Exception
    {

        public ListaVaciaError(string message):base(message) 
        { 
        
        }

        public ListaVaciaError(string message,Exception excepcion) : base(message,excepcion)
        {

        }
    }
}
