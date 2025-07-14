namespace Ej_2_6_Auto
{
    internal class Program
    {

        static void Main(string[] args)
        {
            AutoClass AutoNaftero = new AutoClass(10);

            AutoNaftero.CargarCombustible(50);

            AutoNaftero.Conducir(111);
        }
    }
}
