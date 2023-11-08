namespace Entidades
{
    public abstract class Persona
    {

        protected string nombre;
        protected string apellido;
        protected int dni;
        protected DateTime fechaNacimiento;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }
        
        protected Persona()
        {

        }

        protected Persona(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
        }


        //SOBRECARGA DE OPERADORES

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


        public override string ToString()
        {
            return $"{this.Nombre.ToUpper()} {this.Apellido.ToUpper()}";
        }

    }
}