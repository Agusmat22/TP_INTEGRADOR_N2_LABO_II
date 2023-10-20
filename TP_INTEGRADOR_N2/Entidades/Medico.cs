using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EEspecialidad
    {
        Pediatria,
        Clinico,
        Traumatologia
    }

    public class Medico : Persona
    {
        private long numeroMatricula;
        private EEspecialidad especialidad; 

        /// <summary>
        /// Llamara al constructor de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        private Medico(string nombre, string apellido, long dni, DateTime fechaNacimiento) 
            : base(nombre, apellido, dni, fechaNacimiento)
        {

        }

        /// <summary>
        /// Este constructor sobrecargado sera publico y utilizado para crear los medicos 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="numeroMatricula"></param>
        /// <param name="especialidad"></param>
        public Medico(string nombre, string apellido, long dni, long numeroMatricula, DateTime fechaNacimiento, EEspecialidad especialidad)
            :this(nombre,apellido,dni, fechaNacimiento)
        {
            this.numeroMatricula = numeroMatricula;
            this.especialidad = especialidad;
        }

        //PROPIEDADES

        public long NumeroMatricula
        {
            get { return this.numeroMatricula; }
        }

        public EEspecialidad Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }

        //METODOS

        /// <summary>
        /// Este metodo atendera a un paciente en la guardia, valida si este NO fue atendido y lo atendera, 
        /// caso contrario NO lo atendera y retornara false
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns>Retornara true si el paciente no estaba atendido, caso contrario false</returns>
        public bool AtenderPaciente(Paciente paciente)
        {
            if (paciente.Atendido is false)
            {
                paciente.Atendido = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
