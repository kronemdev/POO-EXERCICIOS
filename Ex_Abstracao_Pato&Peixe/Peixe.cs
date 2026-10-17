using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_Pato_Peixe
{
    internal class Peixe : INadador
    {
        public void Nadar()
        {
            Console.WriteLine("Peixe nadando");
        }
    }
}
