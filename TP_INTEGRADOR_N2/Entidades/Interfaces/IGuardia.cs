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
        public string TipoGuardia { get; set; } //sera utilizado para asignar la especialidad de guardia
        public bool EnEspera { get; set; }//sirve para consultar si el paciente se encuentra en espera
    }
}
