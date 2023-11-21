using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloGuardarRegistroException : Exception
    {

        public FalloGuardarRegistroException(string msg) :base(msg)
        { 
        }

        public FalloGuardarRegistroException(string msg,Exception ex) : base(msg, ex)
        {
        }
    }
}
