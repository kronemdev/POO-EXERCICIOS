using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO_Boletim
{
    internal class Boletim
    {
        public string Aluno { get; set; }
        private double nota;

        public void DefinirNota(double valor)
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
        public double ObterNota()
        {
            return nota;

        }
    }
}
