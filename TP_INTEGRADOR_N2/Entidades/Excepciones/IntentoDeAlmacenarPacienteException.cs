using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class IntentoDeAlmacenarPacienteException :Exception
    {
        public IntentoDeAlmacenarPacienteException(string message) : base(message) 
        { 
        
        }

        public IntentoDeAlmacenarPacienteException(string message,Exception ex) : base(message,ex)
        {

        }
    }
}
