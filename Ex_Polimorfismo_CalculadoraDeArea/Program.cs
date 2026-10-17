using Ex_Polimorfismo_CalculadoraDeArea;
Console.Write("Digite a Area do Quadrado: ");
double areaQuadrado = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Digite a Largura: ");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Digite a Altura: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine(" ");
CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(areaQuadrado)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(largura, altura)}");