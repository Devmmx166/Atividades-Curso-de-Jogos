namespace AT13;

class Program
{
    static void Main(string[] args)
    {
    // Gerar numeros aleatorios com limitação passada por console inicial e final

        Console.WriteLine("Informe o numero  inicial:");
        int numIni = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o numero final:");
        int numfim = int.Parse(Console.ReadLine());

        //Padrão
        // Random random = new Random();
        // int rand = random.Next(numIni,numfim);

        //Abreviado
        int rand = new Random().Next(numIni,numfim);

        Console.WriteLine($"Numero inicial é {numIni} e final é {numfim} numero gerado é ({rand})");

    }
}
