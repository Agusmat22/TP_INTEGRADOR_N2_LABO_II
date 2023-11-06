using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class LecturaRegistrosExcepcion : Exception
    {

        public LecturaRegistrosExcepcion(string mensaje):base(mensaje)
        {

        }
        public LecturaRegistrosExcepcion(string mensaje,Exception ex) : base(mensaje,ex)
        {

        }
    }
}
