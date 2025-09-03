namespace At005;

class Program
{
    static void Main(string[] args)
    {
        int dia;
        int mes;
        int ano;

        Console.WriteLine("|Informe que dia:");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("|Informe que mes:");
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine("|Informe que ano:");
        ano = int.Parse(Console.ReadLine());
        Console.WriteLine($"|A data informada foi: ({dia}/{mes}/{ano})");
        
        
    }
}
