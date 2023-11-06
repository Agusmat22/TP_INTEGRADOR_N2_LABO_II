using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class LecturaPacienteExcepcion : Exception
    {

        public LecturaPacienteExcepcion(string mensaje):base(mensaje)
        {

        }
        public LecturaPacienteExcepcion(string mensaje,Exception ex) : base(mensaje,ex)
        {

        }
    }
}
