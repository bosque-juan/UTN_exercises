using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_3_Punto
{
    internal class Punto
    {
        private double EjeX = 0;
        private double EjeY = 0;

        public Punto() { }

        public Punto(double x, double y)
        {
            this.EjeX = x;
            this.EjeY = y;
        }

        public string PuntoCoordenada()
        { 
            return $"{EjeX};{EjeY}"; 
        }

        public string DistanciaAlOrigen()
        {
            return $"La distancia al origen es: {(Math.Sqrt(Math.Pow(EjeX,2) + Math.Pow(EjeY,2))).ToString()}";
        }
    }
}
