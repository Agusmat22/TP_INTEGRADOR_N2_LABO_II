﻿using Entidades.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void ActualizaPacientes(List<Paciente> lista,int intervalo);

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
        public event ActualizaPacientes OnActualizarLista;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellation;
        private Task actualizacion;
        private int invervaloTiempo;


        public CentroMedico(int invervaloTiempo)
        {
            this.pacientes = new List<Paciente>();
            this.medicos = new List<Medico>();
            this.invervaloTiempo = invervaloTiempo;

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
        

        public void ConsultarModificacionPacientes()
        {
            
            
        }

        /// <summary>
        /// Actualiza la lista de pacientes mediante un evento
        /// </summary>
        public void ActualizacionPacientes()
        {
            while (!cancellation.IsCancellationRequested)
            {
                if (this.OnActualizarLista is not null)
                {
                    List<Paciente> pacientesModificados = ADOPacientes.ObtenerModificados();
                    if (pacientesModificados.Count > 0)
                    {
                        this.pacientes.AddRange(pacientesModificados);
                        this.OnActualizarLista.Invoke(this.Pacientes, this.invervaloTiempo);

                    }
                }

                Thread.Sleep(this.invervaloTiempo);
            }
        }

        public void IniciarActualizacion()
        {
            if(this.actualizacion is null)
            {
                this.cancellationTokenSource = new CancellationTokenSource();
                this.cancellation = this.cancellationTokenSource.Token;

                //instancio el hilo
                this.actualizacion = new Task(this.ActualizacionPacientes, this.cancellation);
            }

            //VALIDAR QUE ONDA ACAAAA
            if (!(this.actualizacion.Status == TaskStatus.Running || this.actualizacion.Status == TaskStatus.WaitingForActivation))
            {
                //inicio la tarea en segundo plano
                this.actualizacion.Start();
            }
            
        }

        public void CancelarActualizacion()
        {
            //cancelo el hilo
            this.cancellationTokenSource.Cancel();
        }

    }
}
