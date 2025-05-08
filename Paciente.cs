using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3_2_Clinica
{
    internal class Paciente : Persona
    {
        protected string ObraSocial;
        protected string HistoriaClinica;

        public Paciente() : base()
        {
            this.ObraSocial = string.Empty;
            this.HistoriaClinica = string.Empty;
        }
        public Paciente(string nombre, int DNI, string telefono, bool sexo, string obraSocial, string historiaClinica) : base(nombre, DNI, telefono, sexo)
        {
            this.ObraSocial = obraSocial;
            this.HistoriaClinica = historiaClinica;
        }

        public string obraSocial
        {
            get { return this.ObraSocial; }
            set { this.ObraSocial = value; }

        }
        public string historiaClinica
        {
            get { return this.HistoriaClinica; }
            set { this.HistoriaClinica = value; }

        }
        public override string ToString()
        {
            return base.ToString() + $" {obraSocial}, {historiaClinica}";
        }
    }
}
