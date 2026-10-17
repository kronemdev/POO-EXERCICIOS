using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Abstracao_FormasDePagamento
{
    internal class Cartao : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor} no cartão");
        }

    }
    
}
