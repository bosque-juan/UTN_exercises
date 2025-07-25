using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
//    Es un tipo especial de asociación.

//El Libro tiene un Autor, pero el autor puede existir por separado.

//El  libro podría ser compartido por varios autores.

//💡 Esto cuadra perfecto con tu código. Tenés una agregación.
            
    internal class Libro
    {
        private int ISBN;
        private string titulo;
        private Autor autor;
        private int paginas;

        public Libro()
        {
            ISBN = 0;
            titulo = string.Empty;
            this.autor = null;
            this.paginas = 0;
        }

        public Libro(int iSBN, string titulo, Autor autor, int paginas)
        {
            ISBN = iSBN;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        public int pISNB
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string pTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public Autor pAutor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int pPaginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public string LibroMásPaginas(Libro l1, Libro l2)
        {
            return l1.pPaginas > l2.pPaginas ? $"El libro con más páginas es el libro: {l1.MostrarLibro()}" : $"El libro con más páginas es el libro: {l2.MostrarLibro()}";
            //if (l1.pPaginas > l2.pPaginas)
            //{
            //    return $"El libro con más páginas es el libro: {l1.MostrarLibro()}";
            //}
            //else
            //{ return $"El libro con más páginas es el libro: {l2.MostrarLibro()}"; }
        }

        public string LibroAutorGenero(Libro l1, Libro l2)
        {
            return l1.pAutor.Sexo == "M" ? "El autor del libro " + l1.pAutor.Nombre + " es Masculino" : "La autora del libro " + l1.pAutor.Nombre + " es Femenino";
            //if (l1.pAutor.Sexo == "M")
            //{
            //    return "El autor del libro " + l1.pAutor.Nombre + " es Masculino";
            //}
            //{

            //    return "La autora del libro " + l1.pAutor.Nombre + " es Femenino";
            //}
        }
        public string MostrarLibro()
        {
            return $"El titulo del libro es: {pTitulo}, \n" +
                 $"  del autor {pAutor.MostrarDatos()}; " +
                 $" \n y contiene la cantidad de: {pPaginas}";
        }
    }
}
