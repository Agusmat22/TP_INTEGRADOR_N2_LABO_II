using Entidades.BaseDeDatos;
using Entidades.MetodosDeExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void ActualizaPacientes();

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
        /// Reemplaza un paciente en la lista pacientes
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>True si se pudo agregar, False si no se pudo</returns>
        public bool Reemplazar(Paciente paciente2)
        {
            //Valido que sea del tipo medico y pregunto si no son iguales
            foreach (Paciente paciente in this.Pacientes)
            {
                if (paciente2.Equals(paciente))
                {
                    //REEMPLAZO EL PACIENTE DE LA LISTA CON EL QUE INGRESO POR PARAMETRO
                    //OBTENGO EL INDICE DEL PACIENTE Y LO REEMPLAZO POR POSICION
                    this.Pacientes[this.Pacientes.IndexOf(paciente)] = paciente2;
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// Agrega un medico a la lista
        /// </summary>
        /// <param name="persona"></param>
        /// <returns>True si se pudo agregar, False si no se pudo</returns>
        public bool Agregar(Medico medico2)
        {
            //Valido que sea del tipo medico y pregunto si no son iguales
            foreach (Medico medico in this.Medicos)
            {
                if (medico2.Equals(medico))
                {
                    return false;
                }
            }

            this.Medicos.Add(medico2);
            return true;
        }

        /// <summary>
        /// Elimina un paciente de la DB y lista pacientes
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EliminarPacientes(Paciente paciente)
        {
            try
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
            }
            catch (Exception) 
            {
                throw;
            }
            

            return false;
        }

        /// <summary>
        /// Elimina un medico de la DB y lista 
        /// </summary>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public bool EliminarMedico(Medico medico)
        {
            try
            {
                foreach (Medico item in this.Medicos)
                {
                    if (medico.Equals(item))
                    {
                        //indico que remueva este medico
                        this.Medicos.Remove(medico);
                        ADOMedicos.Eliminar(medico);
                        return true;
                    }
                }
            }
            catch (Exception) 
            { 
                throw; 
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
            foreach (Paciente item in this.Pacientes)
            {
                if (busqueda(item))
                {
                    return item;
                }
            }

            return null;
        }

        /// <summary>
        /// Devuelve un medico dependiendo el delagado pasado por parametro
        /// </summary>
        /// <param name="busqueda"></param>
        /// <returns></returns>
        public Medico ObtenerMedico(Func<Medico, bool> busqueda)
        {
            foreach (Medico item in this.Medicos)
            {
                if (busqueda(item))
                {
                    return item;
                }
            }

            return null;
        }



        /// <summary>
        /// Actualiza la lista de pacientes mediante un evento
        /// </summary>
        public void ActualizacionPacientes()
        {
            try
            {
                while (!cancellation.IsCancellationRequested)
                {
                    if (this.OnActualizarLista is not null)
                    {
                        List<Paciente> pacientesModificados = ADOPacientes.ObtenerModificados();
                        if (pacientesModificados is not null)
                        {

                            this.ExtenderListaPacientes(pacientesModificados, true);
                            this.OnActualizarLista.Invoke();

                        }
                    }

                    Thread.Sleep(this.invervaloTiempo);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al obtener los pacientes modificados de la DB en el hilo secundario", ex);
            }
            
        }

        /// <summary>
        /// Inicia el hilo
        /// </summary>
        public void IniciarActualizacion()
        {
            if(this.actualizacion is null)
            {
                this.cancellationTokenSource = new CancellationTokenSource();
                this.cancellation = this.cancellationTokenSource.Token;

                //instancio el hilo y le agrego el metodo que quiero en segundo plano
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
            if (this.cancellationTokenSource is not null)
            {
                this.cancellationTokenSource.Cancel();               
            }
            
        }

    }
}
