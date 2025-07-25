namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar autores
            Autor a1 = new Autor("Juan Bosque", 232323, "H",2);
            Autor a2 = new Autor("J k. Rowling", 232223, "F",3);
            Autor a3 = new Autor("Juan Bosque", 232323, "H",4);
            Autor a4 = new Autor();


            //Instanciar libros con autore entre otros parámetros
            Libro blancaNieves = new(1222, "blancaNieves",a1 , 300);
            Libro harryPoter = new(1233, "El prisionero de Azcaban", a2, 350);
            Libro harryPoter1 = new(1233, "El prisionero de Azcaban1", a3, 350);

            //instanciar estanteria y agregar libros en ella, y mostrarlos
            Estanterias nuevoEstante = new();
            nuevoEstante.AgregarLibro(blancaNieves);
            nuevoEstante.AgregarLibro(harryPoter);
            nuevoEstante.AgregarLibro(harryPoter1);
            Console.WriteLine(nuevoEstante.MostrarLibro());
  
            Console.ReadKey();
            //Console.WriteLine(blancaNieves.pAutor.MostrarAutor()+ " Autor");
            //Console.WriteLine(blancaNieves.LibroMásPaginas( blancaNieves,harryPoter));
           
        }
    }
}
