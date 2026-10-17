using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo_InstrumentoViolao
{
    internal class Instrumento
    {
        public virtual void Tocar()
        {
            Console.WriteLine("Tocando um instrumento...");
        }
    }
}
