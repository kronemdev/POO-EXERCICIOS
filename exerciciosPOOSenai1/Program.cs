using exerciciosPOOSenai;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Ana";
pessoa1.Idade = 25;
Console.WriteLine(" ");

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Bruno";
pessoa2.Idade = 31;
Console.WriteLine(" ");
pessoa1.Apresentar();
pessoa2.Apresentar();
Console.ReadKey();

