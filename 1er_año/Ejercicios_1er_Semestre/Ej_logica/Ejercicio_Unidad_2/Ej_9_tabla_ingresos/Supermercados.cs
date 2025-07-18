using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_9_tabla_ingresos
{
    internal class Supermercados
    {
        private double[] Ingresos = new double[3];
        public Supermercados(double mes1, double mes2, double mes3)
        {
            Ingresos[0] = mes1;
            Ingresos[1] = mes2;
            Ingresos[2] = mes3;
        }
        public double mes1 { 
            get { return Ingresos[0]; } 
            set { Ingresos[0] = value; }
        }
        public double mes2
        {
            get { return Ingresos[1]; }
            set { Ingresos[1] = value; }
        }
        public double mes3
        {
            get { return Ingresos[2]; }
            set { Ingresos[2] = value; }
        }
    }

}
