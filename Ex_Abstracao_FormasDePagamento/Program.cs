using Ex_Abstracao_FormasDePagamento;

Pix pix = new Pix();
Cartao cartao = new Cartao();

pix.Pagar(50);
Console.WriteLine(" ");
cartao.Pagar(120);