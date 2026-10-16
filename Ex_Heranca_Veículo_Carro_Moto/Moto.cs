using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca02
{
    public class Moto : Veiculo    // classe filha do veiculo
    {
        public int Cilindradas { get; set; } // propriedade

        public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo) // construtor
        {
            Cilindradas = cilindradas;
        }

        public void ExibirCilindradas()  // metodo
        {
            Console.WriteLine($" Cilindradas: {Cilindradas}cc");
        }


    }
}
