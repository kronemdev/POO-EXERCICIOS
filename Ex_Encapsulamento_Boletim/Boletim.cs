using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO_Boletim
{
    internal class Boletim
    {
        public string Aluno { get; set; } //propriedade
        private double nota;

        public void DefinirNota(double valor) //metodo para definir a nota
        {
            if (valor < 0 || valor > 10)
            {
                Console.WriteLine($"Nota invalida: {valor}");
            }
            else
            {
                nota = valor;
            }
        }
        public double ObterNota() //metodo para obter a nota
        {
            return nota;

        }
    }
}
