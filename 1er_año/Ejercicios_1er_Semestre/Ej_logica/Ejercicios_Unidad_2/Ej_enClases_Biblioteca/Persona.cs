using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string nombre;
        protected int documento;
        protected string sexo;
        public Persona()
        {
            this.nombre = string.Empty;
            this.documento = 0;
            this.sexo = string.Empty;
        }
        public Persona(string nombre, int documento, string sexo)
        {
            this.nombre = nombre;
            this.documento = documento;
            this.sexo = sexo;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public abstract string MostrarDatos();


    }
}
