using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercicio_sala_poo
{
    public class ClassePedido
    {
        public string NomeDOCLiente;
        public string Item;
        public int Quantidade;
        public double preco;



        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome Do Cliente: {NomeDOCLiente}");
            Console.WriteLine(" ");
            Console.WriteLine($"Item: {Item}");
            Console.WriteLine(" ");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine(" ");
            Console.WriteLine($"Preço: R${preco}");
        }
    }

}
