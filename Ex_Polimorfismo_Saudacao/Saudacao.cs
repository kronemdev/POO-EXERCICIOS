using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo_Saudacao
{
    public class Saudacao
    {
        public string Cumprimentar() //metodo
        {
            return "Olá!"; 
        }
        public string Cumprimentar(string nome) // metodo
        {
            return $"Olá,{nome}";
        }
        public string Cumprimentar(string nome, int idade) // metodo
        {
            return $"Olá, {nome}! Voce tem {idade} anos.";
        }

    }
}
