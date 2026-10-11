using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO3_Usuario
{
    internal class Usuario
    {
        public string Login { get; set; }

        private string Senha;

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
        public bool ConferirSenha(string tentativa)
        {
            if(tentativa == Senha)
            {
                return true;
            }
            return false;
        }
        public void TrocarSenha(string senhaAtual, string novaSenha)
        {
            if(senhaAtual == Senha)
            {
                Senha = novaSenha;
                Console.WriteLine("Senha Alterada!");
            }
            else
            {
                Console.WriteLine("Senha Atual Incorreta!");
            }
        }
    }
}
