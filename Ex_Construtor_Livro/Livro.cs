using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO1_Livro
{
    internal class Livro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;

        public Livro(string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public void Exibir()
        {
            Console.WriteLine($" {Titulo} , {Autor} ({Paginas} Paginas)");
           
        }
    }
}
