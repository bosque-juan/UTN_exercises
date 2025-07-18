using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_9_tabla_ingresos
{
    internal class Persona_practica
    {


        public string? nombre;
        public string? apellido;
        public Persona_practica(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string ShowPerson()
        {
            return $"El nombre de la persona es: {nombre}, {apellido}";
        }

    }
}
