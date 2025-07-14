using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_6_Auto
{
    internal class AutoClass
    {
        // Atributos 
        private double CombustibleTanque = 0;
        // Atributos pre seteados para el conductor
        private int CapacidadTanque = 54;
        private double Autonomia = 11;


        // Constructores
        public AutoClass() {  }

        public AutoClass(double CombustibleTanque)
        {
            this.CombustibleTanque = CombustibleTanque;
        }


        // Propiedades
        public double pCombustibleTanque
        {
            get { return CombustibleTanque; }
            set { CombustibleTanque = value; }
        }

        public int pCapacidadTanque
        {
            get { return CapacidadTanque; }
            set { CapacidadTanque = value; }
        }

        public double pAutonomia
        {
            get { return Autonomia; }
            set { Autonomia = value; }
        }


        // Método Conducir
        public void Conducir(double kilometrosRecorrer)
        {
            double AutonomiaDisponible = pCombustibleTanque * pAutonomia;
            if (AutonomiaDisponible >= kilometrosRecorrer)
            {
                double litrosAconsumir = kilometrosRecorrer / 11;
                Console.WriteLine("litros disponibles en el tanque :" + pCombustibleTanque);
                Console.WriteLine("Con el combustible disponible, el viaje puede ser completado");
                pCombustibleTanque = pCombustibleTanque - litrosAconsumir;
                Console.WriteLine("litros disponibles en el tanque luego del recorrido:" + pCombustibleTanque + " presione enter para siguiente operación");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay suficientemente combusitble en el tanque para recorrer el viaje. Recargar combustible.");
                Console.ReadKey();
            };
        }

        // Metodo Cargar Combustible
        public void CargarCombustible(double litros)
        {
            // Calcula derrame
            double totalPretendidoCargar = pCombustibleTanque + litros;
            double derrame = pCapacidadTanque - totalPretendidoCargar;

            // Carga combustible
            pCombustibleTanque += litros;
            if (derrame <= 0)
            {
                // Resta derrame
                pCombustibleTanque += derrame;

                Console.WriteLine($"Combustible derramado {derrame.ToString()} litros, presione enter para siguiente operación");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Combustible disponible previo a la carga: {pCombustibleTanque} litros.");
                Console.WriteLine($"Combustible cargado exitosamente, {pCombustibleTanque} litros en tanque presione enter para siguiente operación");
                Console.ReadKey();
            };

        }
    }
}
