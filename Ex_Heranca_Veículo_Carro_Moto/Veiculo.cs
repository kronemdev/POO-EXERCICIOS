using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca02
{
    public class Veiculo
    {
        public string Marca { get; set; }     // propriedade
        public string Modelo { get; set; }    // propriedade

        public Veiculo(string marca, string modelo)  // construtor 
        {
            Marca = marca;
            Modelo = modelo;
        }

        public void Exibir()      // Metodo
        {
            Console.WriteLine($" {Marca} {Modelo}");
        }
    }

}
