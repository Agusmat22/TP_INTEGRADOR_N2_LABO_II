using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloModificarPacienteException : Exception
    {

        public FalloModificarPacienteException(string mensaje):base(mensaje) 
        { 
        }

        public FalloModificarPacienteException(string mensaje,Exception ex) : base(mensaje,ex)
        {
        }
    }
}
