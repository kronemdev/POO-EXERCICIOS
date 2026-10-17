using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_Formas
{
    internal class Retangulo : IForma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            largura = largura;
            altura = altura;
        }

    }
}
