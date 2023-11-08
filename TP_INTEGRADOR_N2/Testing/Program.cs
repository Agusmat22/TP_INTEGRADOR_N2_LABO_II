using Entidades;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pac1 = new Paciente("agustin","garcia",43173652,DateTime.Now,EObrasSocial.UP,123456);
            Paciente pac2 = new Paciente("Sofia","isunza",43173652, DateTime.Now, EObrasSocial.OSPRERA, 3131112);
            Console.WriteLine(pac1 == pac2);

            Console.WriteLine(pac2.Id);
            
            Console.WriteLine(pac2.Id);



        }
    }
}