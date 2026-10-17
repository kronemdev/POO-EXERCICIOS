using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Polimorfismo_InstrumentoViolao
{
    internal class Violao : Instrumento
    {
        public override void Tocar()
        {
            Console.WriteLine("Violao: Plim Plim");
        }
    }
}
