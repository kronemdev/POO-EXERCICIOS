using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_Pato_Peixe
{
    internal class Pato : IVoador,INadador
    {
        public void Voar()
        {
            Console.WriteLine("Pato voando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato nadando");
        }
    }
}
