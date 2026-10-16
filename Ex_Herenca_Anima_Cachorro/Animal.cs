using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Herenca01
{
    public class Animal
    {
        public string Nome { get; set; } // propriedade

        public void Comer() // metodo
        {
            Console.WriteLine($"{Nome} Está Comendo.");
        }
    }
    
}
