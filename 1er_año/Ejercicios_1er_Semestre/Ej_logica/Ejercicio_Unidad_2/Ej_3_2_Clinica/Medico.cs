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
        protected string CostoConsulta;

        // Constructor
        public Medico() : base()
        {
            this.Especialidad = string.Empty;
            this.CostoConsulta = string.Empty;
        }
        public Medico(string nombre, string DNI, string telefono, bool sexo, string especialidad, string costoConsulta) : base(nombre, DNI, telefono, sexo)
        {
            this.Especialidad = especialidad;
            this.CostoConsulta = costoConsulta;
        }

        // Properties
        public string especialidad
        {
            get { return this.Especialidad; }
            set { this.Especialidad = value; }

        }
        public string costoConsulta
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
