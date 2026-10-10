using exercicioPOO02._3_ConversorDeTemperatura;

Conversor conv = new Conversor();

double f = conv.CelsiusParaFahrenheit(25);
Console.WriteLine($"25ºC = {f}ºF");
if (conv.EstaQuente(35))
{
    Console.WriteLine("35ºC: Está quente!");
}
if(!conv.EstaQuente(18))
{
    Console.WriteLine("18ºC: Não está quente.");
}
