using System;

namespace Ej2_2_Silo.Silo;

internal class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido ! para calcular el volumen total del silo por favor ingrese:");
        //solicita valores del constructor

        Console.WriteLine("Altura del cuerpo del silo:");
        double Altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Perfecto, ahora ingrese altura del techo del silo:");
        double AlturaTecho = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Por último ingrese altura del radio del silo:");
        double Radio = Convert.ToDouble(Console.ReadLine());
        Ej_2_Silos.Silo SiloVolume = new(Altura, AlturaTecho, Radio);
        string VolumeSilo = Math.Round(SiloVolume.VolumnenSilo,2).ToString();
        Console.WriteLine($" El volumen total del Silo es de {VolumeSilo} metros cúbicos");
    }
}
