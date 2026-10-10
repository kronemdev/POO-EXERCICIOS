using System;
using System.Collections.Generic;
using System.Text;

namespace exercicioPOO02._2_Calculadora
{
    public class Calculadora
    {

        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public void MostrarResultado(int valor)
        {
            
            Console.WriteLine($"Resltado: {valor}");
        }
    }
    
}
