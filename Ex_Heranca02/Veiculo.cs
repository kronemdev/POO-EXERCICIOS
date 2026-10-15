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

    public class Moto : Veiculo    // classe filha do veiculo
    {
        public int Cilindradas { get; set; } // propriedade

        public Moto(string marca,string modelo,int cilindradas): base(marca, modelo) // construtor
        {
            Cilindradas = cilindradas;
        }

        public void ExibirCilindradas()  // metodo
        {
            Console.WriteLine($" Cilindradas: {Cilindradas}cc");
        }


    }
}
