using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo_CalculadoraDeArea
{
    public class CalculadoraDeArea
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }

        public double CalcularArea(double largura, double altura)
        {
            return largura * altura;
        }



    }
}
