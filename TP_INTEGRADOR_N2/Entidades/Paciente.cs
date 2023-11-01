using System;
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
        private int cantidadAtenciones;
        private EObrasSocial obraSocial;
        private List<string> historiaClinica;
        public Paciente(string nombre, string apellido, long dni,DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado) 
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            this.numeroAfiliado = numeroAfiliado;

            //El paciente cuando se cargue por defecto no estara atendido
            this.atendido = false;
            this.obraSocial = obraSocial;

        }

        //Sobrecargo el constructor para que se pueda agregar el numero de afiliado
        public Paciente(string nombre, string apellido, long dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado, List<string> historiaClinica)
            :this(nombre,apellido,dni,fechaNacimiento, obraSocial,numeroAfiliado)
        {
            this.historiaClinica = historiaClinica;
        }

        //Sobrecargo el constructor para que se pueda agregar la cantidad de atenciones
        public Paciente(string nombre, string apellido, long dni, DateTime fechaNacimiento, EObrasSocial obraSocial, long numeroAfiliado, List<string> historiaClinica, int cantidadAtenciones)
            : this(nombre, apellido, dni, fechaNacimiento,obraSocial ,numeroAfiliado,historiaClinica)
        {
            this.cantidadAtenciones = cantidadAtenciones;
        }

        //Aca aplicare la logica para cuando el paciente sea atendido
        private bool Atendido
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

        public int CantidadDeConsultas
        {
            get { return this.CantidadDeConsultas; }

        }

        public long NumeroAfiliado
        {
            get {return this.numeroAfiliado; } 
                   
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
                this.cantidadAtenciones++;

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

    }
}
