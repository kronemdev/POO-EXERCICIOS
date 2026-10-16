using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_3_lampada
{
    public class Lampada
    {
        public bool Ligada = true;
       
        public string Status;

     
        public string Ligar()
        {
            Ligada = false;
            return  "A lâmpada está desligada.";
        }
        public string Desligar()
        {
            Ligada = false;
            return "A lâmpada está ligada.";
        }
        public string Alternar()
        {
            if (Alternar != Ligar)
            {
                return "A lâmpada está ligada.";
            }
            else
            {
                return "A lâmpada está desligada.";
            }
        }
       
       public string MostrarEstado()
        {
            return $"Meu nome é Ana";
        }
    }
}
