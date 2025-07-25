using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
namespace Biblioteca
{
    public class Autor : Persona
    {
        private int CantLIbrosEscritos;

        public Autor(string nombre, int documento, string sexo, int cantidadLibrosEscritos) : base(nombre, documento, sexo)
        {
            this.CantLIbrosEscritos = cantidadLibrosEscritos;

        }
        public Autor() : base()
        {
            this.CantLIbrosEscritos = 0;

        }
        public int cantidadLibrosEscritos
        {
            get { return CantLIbrosEscritos; }
        }


        public override string MostrarDatos()
        {
            return "Nombre: " + Nombre + "\n" +
                   "Documento: " + Documento + "\n" +
                   "Sexo: " + this.MostrarSexo() + "\n" +
                   "Cantidad de libros escritos: " + cantidadLibrosEscritos + "\n";

        }

        public string MostrarSexo()
        {
            string s = "";
            if (Sexo == "M")
            {
                s = "Mujer";
            }
            else
            {
                s = "Hombre";
            }
            return s;

        }


    }

}