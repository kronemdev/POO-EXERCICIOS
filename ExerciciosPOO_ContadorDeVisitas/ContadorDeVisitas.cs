using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO_ContadorDeVisitas
{
    internal class ContadorDeVisitas
    {
        private int visitas;


        public void RegistrarVisita()
        {
             visitas++;
        }
        public int ObterTotal()
        {
            return visitas;
        }
    }
}
