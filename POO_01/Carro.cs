using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Carro
    {
        // ATRIBUTOS
        public string Marca;
        public string Modelo;
        public int Ano;


        // METODOS
        // MOSTRAR AS INFORMAÇÕES DO CARRO 

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine(" ");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ano: {Ano}");
        }
    }
}
