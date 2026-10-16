using Ex_Heranca03;
Console.WriteLine("======================================   FIXA DO FUNCIONARIO   ======================================");
Console.WriteLine(" ");
Console.Write("Nome do Funcionario: ");
string nome = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Salario do Funcionario: ");
double salario = double.Parse(Console.ReadLine());
Console.WriteLine(" ");

Funcionario f1 = new Funcionario(nome,salario);

Console.WriteLine(" ======================================   FIXA DO GERENTE   ======================================");
Console.WriteLine(" ");
Console.Write("Digite o Nome do Gerente: ");
string nomeGerente = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite o salario do Gerente: ");
double salarioGerente = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Digite o bonus do Gerente: ");
double bonusGerente = double.Parse(Console.ReadLine());
Console.WriteLine(" ");

Gerente gerente = new Gerente(nomeGerente, salarioGerente,bonusGerente);

Console.WriteLine("======================================   SAÍDA ESPERADA   ======================================");
Console.WriteLine(" ");

Console.WriteLine($"{f1.Nome}: R$ {f1.Salario:F2}");
Console.WriteLine(" ");
Console.WriteLine($"{gerente.Nome}: R$ {gerente.Salario:F2} + bônus = R$ {gerente.SalarioComBonus():F2}");
