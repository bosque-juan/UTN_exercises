
namespace Ej_10_Auto_asociacion;

internal class Program
{
    static void Main(string[] args)
    {
        TanqueAuto TanqueVolkswagen = new(54, 12);// capacidad tanque, litros primera carga

        AutoClass AutoNaftero = new AutoClass(11, TanqueVolkswagen);// autonomía del auto

        float NivelTanque = AutoNaftero.tanque.ConsumirCombustible(0f);
        if (NivelTanque < 9.26) { Console.WriteLine(AutoNaftero.tanque.NivelTanqueCheck()); }

        Console.WriteLine(AutoNaftero.CargarCombustible(50));
        Console.WriteLine(AutoNaftero.Conducir(111));

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();

    }
}
