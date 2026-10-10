using ExerciciosPOO_ContadorDeVisitas;

ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisita();
contador.RegistrarVisita();
contador.RegistrarVisita();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");