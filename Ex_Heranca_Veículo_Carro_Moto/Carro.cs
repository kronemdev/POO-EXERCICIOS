using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca02
{
    public class Carro : Veiculo    // classe filha do veiculo
    {

        public int Portas { get; set; }    // propriedade

        public Carro(string marca, string modelo, int portas) : base(marca, modelo)  // construtor
        {
            Portas = portas;
        }

        public void ExibirPortas()    // Metodo
        {
            Console.WriteLine($" Portas: {Portas}");
        }
    }
}
