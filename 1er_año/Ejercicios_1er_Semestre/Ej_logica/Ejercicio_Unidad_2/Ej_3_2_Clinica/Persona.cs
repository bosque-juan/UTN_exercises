using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_3_2_Clinica
{
    internal class Persona
    {
        protected string Nombre;
        protected string DNI;
        protected string Telefono;
        protected bool Sexo;

        public Persona()
        {
            this.Nombre = string.Empty;
            this.DNI = string.Empty;
            this.Telefono = string.Empty;
            this.Sexo = false;
        }
        public Persona(string nombre,string DNI, string telefono, bool sexo)
        {
            this.Nombre = nombre;
            this.DNI = DNI;
            this.Telefono = telefono;
            this.Sexo = sexo;
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string dni
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public string telefono
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public bool sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public override string ToString()
        {
            return $"{nombre}, {dni}, {telefono}, {(sexo ? "Hombre" : "Mujer")}";
        }
    }
}
