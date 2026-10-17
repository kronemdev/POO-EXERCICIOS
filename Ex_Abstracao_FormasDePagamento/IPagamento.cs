using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_FormasDePagamento
{
    internal interface IPagamento
    {
        void Pagar(double valor);
    }
}
