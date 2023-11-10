using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class PacienteNoEncontradoException : Exception
    {
        public PacienteNoEncontradoException(string mensaje):base(mensaje)
        {

        }

        public PacienteNoEncontradoException(string mensaje,Exception ex) : base(mensaje, ex)
        {

        }
    }
}
