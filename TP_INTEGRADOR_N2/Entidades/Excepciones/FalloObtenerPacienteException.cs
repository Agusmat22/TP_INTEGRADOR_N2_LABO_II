using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class FalloObtenerPacienteException :Exception
    {
        public FalloObtenerPacienteException(string message) : base(message) 
        { 
        
        }

        public FalloObtenerPacienteException(string message,Exception ex) : base(message,ex)
        {

        }
    }
}
