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

    public class Gerente : Funcionario
    {
        public double Bonus { get; set; } // propriedade

        public Gerente (string nome, double salario, double bonus) : base(nome,salario) // construtor
        {
            Bonus = bonus;
        }
        public double SalarioComBonus() // metodo 
        {
            return Salario + Bonus;
        }
    }
}
