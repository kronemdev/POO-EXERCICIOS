using ExercicioPOO2;

Retangulo ret = new Retangulo();
Console.WriteLine("Dados do Retângulo:");
ret.Largura = 5;
ret.Altura = 3;
Console.WriteLine($"Área: {ret.CalcularArea()}");
Console.WriteLine($"Perímetro: {ret.CalcularPerimetro()}");