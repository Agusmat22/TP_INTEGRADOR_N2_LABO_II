using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IGuardia
    {
        //Con esta etiqueta ignoro para que al momento de realizar la exportacion no lo lo lea
        [JsonIgnore]
        public string TipoGuardia { get; set; }
    }
}
