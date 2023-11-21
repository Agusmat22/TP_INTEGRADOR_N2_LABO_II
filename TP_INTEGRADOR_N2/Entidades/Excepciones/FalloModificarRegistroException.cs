using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloModificarRegistroException : Exception
    {

        public FalloModificarRegistroException(string mensaje):base(mensaje) 
        { 
        }

        public FalloModificarRegistroException(string mensaje,Exception ex) : base(mensaje,ex)
        {
        }
    }
}
