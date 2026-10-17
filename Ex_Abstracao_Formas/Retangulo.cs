using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_Formas
{
    internal class Retangulo : IForma
    {
        public double Largura { get; set; } // propriedade
        public double Altura { get; set; } // propriedade

        public Retangulo(double largura, double altura) // construtor
        {
            Largura = largura;
            Altura = altura;
        }
        public double CalcularArea()
        {
            return Largura * Altura;
        }

    }
}
