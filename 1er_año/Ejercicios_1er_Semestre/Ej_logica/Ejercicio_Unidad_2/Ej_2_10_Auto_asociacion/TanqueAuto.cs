using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_10_Auto_asociacion
{
    internal class TanqueAuto
    {
        // Atributos
        private short CapacidadTanque;
        private float NivelTanque;

        // Constructores
        public TanqueAuto() { }
        public TanqueAuto(short capacidadTanque, float litros)
        {
            this.CapacidadTanque = capacidadTanque;
            this.NivelTanque = litros;
        }

        // Propiedades
        public short capacidadTanque
        {
            get { return CapacidadTanque; }
            set { CapacidadTanque = value; }
        }

        public float nivelTanque
        {
            get { return NivelTanque; }
            set { NivelTanque = value; }
        }

        // Métodos

        public float ConsumirCombustible(float litros)
        {
            if (nivelTanque > litros)
            {
                nivelTanque = nivelTanque - litros;
                return 0;
            }
            if (litros == 0) return nivelTanque;
            return 1;
        }

        public string CargarCombusitble(float litros)
        {
            float CargaPosibleTanque = capacidadTanque - nivelTanque;
            if (CargaPosibleTanque >= litros)
            {
                return $"Carga exitosa tanque, nivel actual del tanque {this.NivelTanqueCheck()} %";
            }
            else
            {
                float CombustibleDerramado = litros - CargaPosibleTanque;
                return $"Cantidad de litros derramados {CombustibleDerramado} litros";
            }
        }

        public string NivelTanqueCheck()
        {
            double porcentajeNivelTanque = nivelTanque * 100 / CapacidadTanque;
            if (porcentajeNivelTanque == 100) return "El tanque está lleno";
            if (porcentajeNivelTanque > 74) return "El tanque está al 75% de su nivel";
            if (porcentajeNivelTanque > 49) return "El tanque está al 50% de su nivel";
            if (porcentajeNivelTanque > 24) return "El tanque está al 75% de su nivel";
            if (porcentajeNivelTanque < 9.26) return "Alerta reabastecer combustible";
            return "";
        }
    }
}
