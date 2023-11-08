using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IIdentificadorSql
    {
        /// <summary>
        /// Identificara al objeto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fecha que se crea dicho objeto 
        /// </summary>
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Fecha que se elimina el objeto dentro de la DB
        /// </summary>
        public DateTime FechaEliminacion { get; set; }
    }
}
