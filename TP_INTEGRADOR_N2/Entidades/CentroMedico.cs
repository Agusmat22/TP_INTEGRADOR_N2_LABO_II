using Entidades.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EObrasSocial
    {
        OSECAC,
        OSMEDICA,
        UP,
        OSPRERA
    }

    public class CentroMedico
    {
        
        private List<Paciente> pacientes;
        private List<Medico> medicos;


        public CentroMedico()
        {
            this.pacientes = new List<Paciente>();
            this.medicos = new List<Medico>();

        }

        public List<Paciente> Pacientes
        {
            get 
            {
                return this.pacientes;
            }     
            set
            { 
                this.pacientes = value;
            }
        }

        public List<Medico> Medicos
        {
            get
            {
                return this.medicos;
            }
            set 
            { 
                this.medicos = value;
            }
        }


        /// <summary>
        /// Agrega un paciente a la lista
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>True si se pudo agregar, False si no se pudo</returns>
        public bool Agregar(Paciente paciente2)
        {
            //Valido que sea del tipo medico y pregunto si no son iguales
            foreach (Paciente paciente in this.Pacientes)
            {
                if (paciente2.Equals(paciente))
                {
                    return false;
                }
            }

            this.Pacientes.Add(paciente2);
            return true;
        }

        /// <summary>
        /// Agrega un paciente a la lista
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>True si se pudo agregar, False si no se pudo</returns>
        public bool Agregar(Medico medico2)
        {
            //Valido que sea del tipo medico y pregunto si no son iguales
            foreach (Medico paciente in this.Medicos)
            {
                if (medico2.Equals(paciente))
                {
                    return false;
                }
            }

            this.Medicos.Add(medico2);
            return true;
        }

        /// <summary>
        /// Elimina un paciente si es que se encuentra registrado
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EliminarPacientes(Paciente paciente)
        {
            foreach (Paciente item in this.Pacientes)
            {
                if (paciente.Equals(item))
                {
                    //indico que remueva este paciente
                    this.Pacientes.Remove(paciente);
                    ADOPacientes.Eliminar(paciente);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Elimina un medico si es que se encuentra registrado
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EliminarMedico(Medico medico)
        {
            foreach (Medico item in this.Medicos)
            {
                if (medico.Equals(item))
                {
                    //indico que remueva este medico
                    this.Medicos.Remove(medico);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Devuelve un paciente dependiendo el delagado pasado por parametro
        /// </summary>
        /// <param name="busqueda">El parametro sera un paciente y retornara un bool</param>
        /// <returns></returns>
        public Paciente ObtenerPaciente(Func<Paciente,bool> busqueda)
        {
            foreach (Paciente item in this.pacientes)
            {
                if (busqueda(item))
                {
                    return item;
                }
            }

            return null;
        }
        
    }
}
