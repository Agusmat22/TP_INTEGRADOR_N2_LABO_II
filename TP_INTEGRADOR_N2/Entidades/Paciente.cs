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
        public Paciente(string nombre, string apellido, long dni,DateTime fechaNacimiento) 
            : base(nombre, apellido, dni, fechaNacimiento)
        {
            //El paciente cuando se cargue por defecto no estara atendido
            this.atendido = false;
        }

        //Sobrecargo el constructor para que se pueda agregar el numero de afiliado
        public Paciente(string nombre, string apellido, long dni, DateTime fechaNacimiento, long numeroAfiliado)
            :this(nombre,apellido,dni,fechaNacimiento)
        {
            this.numeroAfiliado = numeroAfiliado;
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


    }
}
