using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3_Contato
{
    internal class Contato
    {
        public string Nome;
        public string Telefone;
        public string Email;

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
        public Contato(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Email = "Não informado";
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
