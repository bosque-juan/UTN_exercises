using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_10_Auto_asociacion
{
    internal class AutoClass
    {
        // Atributos 
        private TanqueAuto? Tanque;
        private short Autonomia;


        // Constructores
        public AutoClass() { }

        public AutoClass(short autonomia, TanqueAuto tanque)
        {
            this.Autonomia = autonomia;
            this.Tanque = tanque;
        }


        // Propiedades
        public TanqueAuto tanque
        {
            get { return Tanque; }
            set { Tanque = value; }
        }


        public short autonomia
        {
            get { return Autonomia; }
            set { Autonomia = value; }
        }


        // Método Conducir
        public string Conducir(float kilometrosRecorrer)
        {
            if (Tanque == null)
                return "Error: el tanque no está inicializado.";
            float EspacioTanque = Tanque.ConsumirCombustible(0f);
            float litrosNecesarios = kilometrosRecorrer / 11;
            if (EspacioTanque > litrosNecesarios)
            {
                Tanque.ConsumirCombustible(litrosNecesarios);
                return $"Combustible disponible para realizar el viaje";

            }
            else
            {
                float LitrosNecesarios = litrosNecesarios - EspacioTanque;
                return $"Combustible insuficiente para realizar el viaje" + "\n" +
                       $"Se necesita recargar al menos {litrosNecesarios} litros, para realizar dicho viaje";
            }
        }

        // Metodo Cargar Combustible
        public string CargarCombustible(float litros)
        {
            string CargarCombustible = Tanque.CargarCombusitble(litros);
            return CargarCombustible;

        }
    }
}
