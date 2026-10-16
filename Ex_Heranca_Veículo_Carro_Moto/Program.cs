using Ex_Heranca02;

Console.WriteLine("======================   FIXA DO CARRO   ================================");
Console.WriteLine(" ");
Console.Write("Digite a Marca do carro: ");
string marca = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite o Modelo do carro: ");
string modelo = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite quantas Portas tem o Carro: ");
int portas = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Carro carro = new Carro(marca,modelo,portas);

Console.WriteLine(" ");
Console.WriteLine("======================   FIXA DA MOTO   ================================");

Console.Write("Digite a Marca da Moto: ");
string marcaMoto = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite o Modelo da Moto: ");
string modeloMoto = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite a Cinlidradas da Moto: ");
int cilindradas = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Moto moto = new Moto(marcaMoto,modeloMoto,cilindradas);

Console.WriteLine(" ");

Console.WriteLine("======================   INFORMAÇÕES DO CARRO   ======================");
 carro.Exibir();
Console.WriteLine(" ");
 carro.ExibirPortas();

 Console.WriteLine(" ");

Console.WriteLine("======================   INFORMAÇÕES DA MOTO   ======================");
 moto.Exibir();
Console.WriteLine(" ");
 moto.ExibirCilindradas();
    

