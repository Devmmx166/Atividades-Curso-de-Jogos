namespace AT05;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Data atual");

      Console.WriteLine("Informe o dia atual:");
      int dia = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês atual:");
      int mes = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o Ano atual:");
      int ano = int.Parse(Console.ReadLine());
   
      Console.WriteLine($"Data ({dia}/{mes}/{ano})");
    }
}
