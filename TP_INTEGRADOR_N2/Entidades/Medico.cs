using Entidades.Interfaces;
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

    public class Medico : Persona, IIdentificadorSql
    {
        private long numeroMatricula;
        private EEspecialidad especialidad; 

        public Medico():base()
        {

        }

        /// <summary>
        /// Llamara al constructor de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        private Medico(string nombre, string apellido, int dni, DateTime fechaNacimiento) 
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
        public Medico(string nombre, string apellido, int dni, long numeroMatricula, DateTime fechaNacimiento, EEspecialidad especialidad)
            :this(nombre,apellido,dni, fechaNacimiento)
        {
            this.numeroMatricula = numeroMatricula;
            this.especialidad = especialidad;
        }

        public Medico(string nombre, string apellido, int dni, long numeroMatricula, DateTime fechaNacimiento, EEspecialidad especialidad, int id)
            : this(nombre, apellido, dni,numeroMatricula, fechaNacimiento, especialidad)
        {
            this.Id = id;
        }

        //PROPIEDADES

        public long NumeroMatricula
        {
            get { return this.numeroMatricula; }
            set { this.numeroMatricula = value; }
        }

        public EEspecialidad Especialidad
        {
            get { return this.especialidad; }
            set { this.especialidad = value; }
        }

        //INTERFAZ
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEliminacion { get; set; }

        //METODOS

        /// <summary>
        /// Este metodo atendera a un paciente en la guardia, valida si este NO fue atendido y lo atendera, 
        /// caso contrario NO lo atendera y retornara false
        /// </summary>
        /// <param name="paciente">El paciente que sera atendido</param>
        /// <returns>Retornara true si el paciente no estaba atendido, caso contrario false</returns>
        public bool AtenderPaciente(Paciente paciente)
        {
            return paciente.Atenderse();
        }

        /// <summary>
        /// Compara por la sobrecarga de operadores de la clase base y tambien por el numero de matrico
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Medico medico && this == medico && this.NumeroMatricula == medico.NumeroMatricula;
        }
    }
}
