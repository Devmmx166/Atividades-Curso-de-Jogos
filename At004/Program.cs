namespace At004;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe O primeo numero:");
        float numero01 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe O segundo numero:");
        float numero02 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe O terceiro numero:");
        float numero03 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe O quarto numero:");
        float numero04 = float.Parse(Console.ReadLine());
        float media = (numero01 + numero02 + numero03 + numero04) / 4;
        Console.WriteLine($"A media dos numeros informados e: {media}");
    
    }
}
