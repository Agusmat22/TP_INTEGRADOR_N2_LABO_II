using Entidades;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pac1 = new Paciente("agustin","garcia",43173652,2659);
            Paciente pac2 = new Paciente("Sofia","isunza",43173652,269);
            Console.WriteLine(pac1 == pac2);
        }
    }
}