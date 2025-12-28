namespace AT10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Converter celsius em Fahrenheit!");
        Console.Write("Informe o valor em Celsius: ");
        float grauCelsius = float.Parse(Console.ReadLine());
        float Fahrenheit = (grauCelsius * 9/5)+32;

        Console.WriteLine($"O valor em Celsius é {grauCelsius} e em Fahrenheit é {Fahrenheit}");
    }
}
