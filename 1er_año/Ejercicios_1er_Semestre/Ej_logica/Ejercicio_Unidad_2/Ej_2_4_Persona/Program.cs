using Ej_2_3_Punto;

namespace Ej_2_3_Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", 25, "Hombre", 30, 1.75);
            persona1.MostrarInfo();
            Console.ReadKey();
        }
    }

}
