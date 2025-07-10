using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_Silos
{
    internal class Silo
    {
        private double Altura = 0;
        private double AlturaTecho = 0;
        private double Radio = 0;
        public Silo() { }
        public Silo(double Altura, double AlturaTecho, double Radio)
        {
            this.Altura = Altura;
            this.AlturaTecho = AlturaTecho;
            this.Radio = Radio;
        }
        public double VolumnenSilo
        {
            get { return ((Math.PI * Math.Pow(Radio, 2)* Altura) + ((1.0 / 3) * Math.PI * Math.Pow(Radio, 2) * AlturaTecho)); }
        }

    }
}
