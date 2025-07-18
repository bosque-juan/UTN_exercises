namespace Ej_2_8_Productos
{
    internal class Program
    {
        class Productos
        {
            private static object totalGastado;
            private string Nombre;
            private double Precio;
            private double Cantidad;


            public Productos()
            {
                this.Nombre = string.Empty;
                this.Precio = 0;
                this.Cantidad = 0;
            }

            public Productos(string nombre, double precio, double cantidad)
            {
                this.Nombre = nombre;
                this.Precio = precio;
                this.Cantidad = cantidad;
            }
            public string nombre
            {
                get { return Nombre; }
            }
            public double precio
            {
                get { return Precio; }
            }
            public double cantidad
            {
                get { return Cantidad; }
            }

            static void Main(string[] args)
            {
                Productos pan = new Productos("Pan", 2000, 2);
                Productos campera = new Productos("Campera", 100000, 1);
                Productos colchon = new Productos("Colchon", 700000, 1);
                Productos lechunga = new Productos("Lechuga", 5000, 1.5);
                Productos carne = new Productos("Carne", 11, 2);


                //Console.WriteLine("Nombre".PadRight(15) + "Sueldo".PadRight(10));
                    Console.WriteLine("Productos".PadRight(15) + "Precios".PadRight(15) + "Cantidad".PadRight(15) + "Total".PadRight(15));
                Console.WriteLine(new string('-', 60));

                Productos[] ProductosArreglo = new Productos[5] { pan, campera, colchon, lechunga, carne };

                double totalGastado = 0;
                for (int i = 0; i < ProductosArreglo.Length; i++)
                {

                    double totalProducto = ProductosArreglo[i].cantidad * ProductosArreglo[i].precio;
                    totalGastado += totalProducto;
                    Console.WriteLine(ProductosArreglo[i].nombre.PadRight(15) + ProductosArreglo[i].precio.ToString().PadRight(15) + ProductosArreglo[i].cantidad.ToString().PadRight(15) + totalProducto.ToString().PadRight(10));


                }
                Console.WriteLine(new string('-', 60));
                Console.WriteLine($"El Total gastado en la compra es de: {totalGastado}");

                Console.WriteLine(new string('-', 60));

            }
        }
    }
}
