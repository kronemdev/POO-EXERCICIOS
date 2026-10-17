
using Ex_Polimorfismo_Saudacao;
Console.Write("Digite Seu Nome: ");
string nome = Console.ReadLine();
Console.WriteLine(" ");
Console.Write("Digite Outro Nome: ");
string nome2 = Console.ReadLine();
Console.WriteLine("");
Console.Write("Digite Sua Idade: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

Saudacao s = new Saudacao();

string mensagem = null;

mensagem = s.Cumprimentar();
Console.WriteLine(mensagem);

nome = s.Cumprimentar(nome);
Console.WriteLine(nome);

nome2 = s.Cumprimentar(nome2, idade);
Console.WriteLine(nome2,idade);



//Console.WriteLine(s.Cumprimentar());
//Console.WriteLine(s.Cumprimentar("Nicolas"));
//Console.WriteLine(s.Cumprimentar("Guilherme", 23));