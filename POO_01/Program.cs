// VARIAVEL
// TIPO NOME 

using POO;
// INSTANCIAR
Carro carroDoNk = new Carro();
carroDoNk.Modelo = "Passat Pointer";
carroDoNk.Marca = "VW";
carroDoNk.Ano = 1986;

carroDoNk.ExibirInformacoes();
Console.WriteLine(" ");
Console.WriteLine("===============================================================================================================");
Console.WriteLine(" ");
Carro CarroDoCliente = new Carro();
CarroDoCliente.Modelo = "corsa ";
CarroDoCliente.Marca = "GM";
CarroDoCliente.Ano = 2001;
CarroDoCliente.ExibirInformacoes();

// classe pedido
// nomeDoCliente, Item, Quantidade,Preco