﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Paciente : Persona
    {
        private long numeroAfiliado;
        private bool atendido;
        private EObrasSocial obraSocial;
        private string historiaClinica;

        //ESTA LOGICA LA ESTOY IMPLEMENTANDO PARA QUE EL MEDICO PUEDA SABER LOS PACIENTES QUE DEBE ATENDER
        public Paciente(): base()
        {

        }


        public Paciente(string nombre, string apellido, int dni,DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado) 
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.numeroAfiliado = numeroAfiliado;

            //El paciente cuando se cargue por defecto no estara atendido
            this.atendido = false;
            this.obraSocial = obraSocial;

        }

        public Paciente(string nombre, string apellido, int dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado,int id)
            : base(nombre, apellido, dni, fechaNacimiento,id)
        {
            this.numeroAfiliado = numeroAfiliado;

            //El paciente cuando se cargue por defecto no estara atendido
            this.atendido = false;
            this.obraSocial = obraSocial;

        }

        /// <summary>
        /// Constructor sobrecargado con ID
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="obraSocial"></param>
        /// <param name="numeroAfiliado"></param>
        /// <param name="id"></param>
        /// <param name="historiaClinica"></param>
        public Paciente(string nombre, string apellido, int dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado, int id, string historiaClinica)
            : this(nombre, apellido, dni, fechaNacimiento, obraSocial, numeroAfiliado,id)
        {
            this.historiaClinica = historiaClinica;
        }

        /// <summary>
        /// Constructor sobrecargado con sin ID
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="obraSocial"></param>
        /// <param name="numeroAfiliado"></param>
        /// <param name="historiaClinica"></param>
        public Paciente(string nombre, string apellido, int dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado, string historiaClinica)
            : this(nombre, apellido, dni, fechaNacimiento, obraSocial, numeroAfiliado)
        {
            this.historiaClinica = historiaClinica;
        }

        public Paciente(string nombre, string apellido, int dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado,bool atendido)
            : this(nombre, apellido, dni, fechaNacimiento, obraSocial, numeroAfiliado)
        {
            this.atendido = atendido;   
        }



        //Aca aplicare la logica para cuando el paciente sea atendido
        public bool Atendido
        {
            get 
            { 
                return this.atendido; 
            }

            set 
            {              
                this.atendido = value;
            }
        }

        public long NumeroAfiliado
        {
            get {return this.numeroAfiliado; } 
            set { this.numeroAfiliado= value; }
                   
        }

        public string HistoriaClinica
        {
            get { return this.historiaClinica; }
            set { this.historiaClinica = value; }
        
        }

        public EObrasSocial ObraSocial
        {
            get { return this.obraSocial; }
            set { this.obraSocial = value; }
        }


        /// <summary>
        /// El paciente realizara una consulta
        /// </summary>
        /// <returns>True si pudo consultar, False en caso que ya haya sido atendido</returns>
        public bool Atenderse()
        {
            if(this.Atendido is false)
            {
                this.Atendido = true;

                return true;
            }

            return false;

        }

        //POLIMORFISMO

        /// <summary>
        /// Sobreescribo el metodo llamando a la sobrecarga del == en la clase base y ademas digo que si los pacientes tienen
        /// el mismo numero de afiliado seran iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Paciente paciente && paciente == this && paciente.numeroAfiliado == this.numeroAfiliado;
        }


        //sobreescribo el TOSTRING para que se muestre en el listbox

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString() + $" | {this.NumeroAfiliado} | {this.obraSocial}");

            return sb.ToString();
        }

        public static bool operator ==(Paciente pac1,Paciente pac2)
        {
            return pac1.Id == pac2.Id;  
        }

        public static bool operator !=(Paciente pac1, Paciente pac2)
        {
            return !(pac1 == pac2);
        }

    }
}
