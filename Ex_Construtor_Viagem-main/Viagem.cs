using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO2_Viagem
{
    internal class Viagem
    {
        public string Destino;
        public int Dias;
        public double ValorDiaria;

        public Viagem(string destino, int dias, double valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }

        public double CalcularValorTotal()
        {
            return Dias * ValorDiaria;
        }
        public void Exibir()
        {
            Console.WriteLine($"Destino: {Destino}, Dias: {Dias}, Valor da Diária: {ValorDiaria}");
        }
    }
}
