using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca03
{
    public class Funcionario
    {
        public string Nome { get; set; } // propriedades
        public double Salario { get; set; }  // propriedades

         public Funcionario (string nome, double salario)  // construtor
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
