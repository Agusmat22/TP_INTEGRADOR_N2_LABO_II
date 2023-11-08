using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloBusquedaPacienteException : Exception
    {

        public FalloBusquedaPacienteException(string mensaje):base(mensaje)
        {

        }
        public FalloBusquedaPacienteException(string mensaje,Exception ex) : base(mensaje,ex)
        {

        }
    }
}
