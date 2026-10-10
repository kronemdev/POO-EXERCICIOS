using ExerciciosPOO_Boletim;

Boletim boletim = new Boletim();
boletim.Aluno = "Ana";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");
