using System;

namespace Ej_2_3_Punto
{
    internal class Persona
    {
        // Atributos
        private string Nombre;
        private int Edad;
        private string Sexo;
        private double Peso;
        private double Altura;

        // Constantes para CalcularIMC
        public const int BAJO_PESO = -1;
        public const int PESO_IDEAL = 0;
        public const int SOBREPESO = 1;

        // Constructor sin parámetro
        public Persona() { }

        // Constructor con parámetros
        public Persona(string nombre, int edad, string sexo, double peso, double altura)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Altura = altura;
        }

        // Método para calcular el IMC
        public int CalcularIMC()
        {
            double imc = Peso / Math.Pow(Altura, 2);
            if (imc < 20) return BAJO_PESO;
            else if (imc <= 25) return PESO_IDEAL;
            else return SOBREPESO;
        }

        // Método para calcular mayoría de edad
        public bool EsMayor()
        {
            return Edad >= 21;
        }

        // Método para mostrar la información
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Altura: {Altura} m");

            int imc = CalcularIMC();
            string imcTexto = imc switch
            {
                BAJO_PESO => "Está por debajo de su peso ideal.",
                PESO_IDEAL => "Está en su peso ideal.",
                SOBREPESO => "Tiene sobrepeso.",
                _ => "No se pudo calcular el IMC."
            };
            Console.WriteLine($"IMC: {imcTexto}");

            Console.WriteLine($"¿Es mayor de edad?: {(EsMayor() ? "Sí" : "No")}");
        }
    }
}






//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ej_2_3_Punto
//{
//    internal class Persona
//    {
//        //Atributos

//        private string Nombre;
//        private int Edad;
//        private string Sexo;
//        private double Peso = 0;
//        private double Altura = 0;

//        //Constantes para CalcularIMC
//        public const int BAJO_PESO = -1;
//        public const int PESO_IDEAL = 0;
//        public const int SOBREPESO = 1;

//        //Constructor sin parametro
//        public Persona() { }

//        //Constructor con prametro
//        public Persona(string Nombre, int Edad, string Sexo, double Peso, double Altura)
//        {
//            this.Nombre = Nombre;
//            this.Edad = Edad;
//            this.Sexo = Sexo;
//            this.Peso = Peso;
//            this.Altura = Altura;
//        }
//        //Metodo par calcular imc
//        public int CalcularIMC()
//        {
//            double IMC = Peso / Math.Pow(Altura, 2);
//            if (IMC < 20) return BAJO_PESO;
//            if (IMC > 20 && IMC <= 25) return PESO_IDEAL;
//            if (IMC > 25) return SOBREPESO;

//        }

//        //Metodo par calcular mayoría de edad
//        public bool EsMayor()
//        {
//            return Edad >= 21;
//        }
//    }
//}
