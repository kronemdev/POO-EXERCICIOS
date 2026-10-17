using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_Formas
{
    internal class Quadrado : IForma
    {
        public double Lado { get; set; } // propriedade

        public Quadrado(double lado) // construtor
        {
            Lado = lado;
        }
        public double CalcularArea()
        {
            return Lado * Lado;

        }

    }
}
