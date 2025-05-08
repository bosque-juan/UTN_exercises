using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3_2_Clinica
{
    internal class Medico : Persona
    {

        // Atributes
        protected string Especialidad;
        protected double CostoConsulta;

        // Constructor
        public Medico() : base()
        {
            this.Especialidad = string.Empty;
            this.CostoConsulta = 0;
        }
        public Medico(string nombre, int DNI, string telefono, bool sexo, string obraSocial, double costoConsulta) : base(nombre, DNI, telefono, sexo)
        {
            this.Especialidad = obraSocial;
            this.CostoConsulta = costoConsulta;
        }

        // Properties
        public string especialidad
        {
            get { return this.Especialidad; }
            set { this.Especialidad = value; }

        }
        public double costoConsulta
        {
            get { return this.CostoConsulta; }
            set { this.CostoConsulta = value; }

        }

        // Method
        public override string ToString()
        {
            return base.ToString() + $" {especialidad}, {costoConsulta}";
        }
    }
}
