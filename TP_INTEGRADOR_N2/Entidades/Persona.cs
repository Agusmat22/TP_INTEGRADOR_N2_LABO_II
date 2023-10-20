namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected long dni;
        protected DateTime fechaNacimiento;

        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }

        public long Dni
        {
            get { return this.dni; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
        }

        protected Persona(string nombre, string apellido, long dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
        }


        //SOBRECARGA DE OPERADOR

        /// <summary>
        /// Valida si dos personas son iguales por el DNI
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Persona a, Persona b) 
        {
            return a.Dni == b.Dni;
        }

        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }

         
    }
}