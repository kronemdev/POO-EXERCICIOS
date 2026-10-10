using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioPOO2._1_SAUDACAO_
{
    public class Pessoa
    {
        public string Nome;
        public string Alguem;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }
        public void CumprimentarAlguem()
        {
            Console.WriteLine($"Olá, {Alguem}! Eu sou {Nome}");
        }
        public string ObterApresentacao()
        {
            Console.WriteLine($"Meu nome é {Nome}"); 
            return Nome;
        }
    }
}
