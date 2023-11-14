using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entidades.Interfaces;


namespace Entidades
{
    public class Paciente : Persona, IIdentificadorSql, IGuardia
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
            : this(nombre, apellido, dni, fechaNacimiento,obraSocial,numeroAfiliado)
        {
           
            //Le asigno a la propiedad hederada de la interfaz
            this.Id = id;

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


        //INTERFAZ
       
        public int Id { get; set; }
       
        public DateTime FechaAlta { get ; set ; }

        //DARLE LOGICA REVISARLA
        [JsonIgnore]
        public string TipoGuardia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool EnEspera { get; set; }


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


        /// <summary>
        /// sobreescribo el TOSTRING para que se muestre en el listbox
        /// </summary>
        /// <returns></returns>
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
