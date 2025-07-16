namespace Ej_2_7_ArregloSuelods
{
    internal class Program
    {
        class Sueldo
        {
            private string NombreEmpleado;
            private float SueldoEmpleado;


            public Sueldo()
            {
                NombreEmpleado = string.Empty;
                SueldoEmpleado = 0.0f;
            }
            public Sueldo(string nombreEmpleado, float sueldoEmpleado)
            {
                this.NombreEmpleado = nombreEmpleado;
                this.SueldoEmpleado = sueldoEmpleado;
            }
            public string nombreEmpleado
            {
                get { return NombreEmpleado; }
                set { NombreEmpleado = value; }

            }
            public float sueldoEmpleado
            {
                get { return SueldoEmpleado; }
                set { SueldoEmpleado = value; }
            }

            public string MostrarEmpleado()
            {
                string sueldo = sueldoEmpleado.ToString();
                return $"El empleado {NombreEmpleado} tiene un sueldo de {sueldo} pesos";
            }
        }
        static void Main(string[] args)
        {
            //Sueldo[] fabrica = new Sueldo[5] { new("Daniel", 500f), new("José", 700f), new("Santiago", 1000f), new("Juan", 800f), new("Marianela", 700f) };
            Sueldo[] fabrica = new Sueldo[1];

            fabrica[0] = new Sueldo("Juan", 200f);
            foreach (var r in fabrica) { Console.WriteLine(r.MostrarEmpleado()); }

            // arreglo tipo tabla - matriz

            //            Sueldo[,] Fabrica = new Sueldo[0,0];
            //            Fabrica[0, 0] = new Sueldo("Juan", 300f);

            //            Sueldo[,] Fabrica = new Sueldo[1, 1];
            //Fabrica[0, 0] = new Sueldo("Juan", 300f);

            Sueldo[,] Fabrica = new Sueldo[2, 2];

            // Cargar datos manualmente
            Fabrica[0, 0] = new Sueldo("Juan", 300f);
            Fabrica[0, 1] = new Sueldo("Ana", 280f);
            Fabrica[1, 0] = new Sueldo("Luis", 320f);
            Fabrica[1, 1] = new Sueldo("Marta", 290f);

            // Mostrar encabezado de tabla
            Console.WriteLine("Nombre".PadRight(15) + "Sueldo".PadRight(10));
            Console.WriteLine(new string('-', 25)); // Separador

            // Mostrar datos en forma de tabla
            //for (fila)}
            // for col
            // así hacemos un recorrido por filas[column, column]
            //for (col)}
            // for fila
            // así hacemos un recorrido por column[fila, fila]
            for (int i = 0; i < Fabrica.GetLength(0); i++)
            {
                for (int j = 0; j < Fabrica.GetLength(1); j++)
                {
                    Console.WriteLine(
                        Fabrica[i, j].nombreEmpleado.PadRight(15) +
                        Fabrica[i, j].sueldoEmpleado.ToString("F2").PadRight(10)
                    );
                }
            }

            // Esperar antes de cerrar la consola
            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }

    }
    }
}
