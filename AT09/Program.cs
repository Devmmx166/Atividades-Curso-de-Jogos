namespace AT09;

class Program
{
    static void Main(string[] args)
    {
        int minutos = 60;

        Console.WriteLine("Calcular horas em minutos.");
        Console.Write("Informe a quantidade de horas:");
        int horas = int.Parse(Console.ReadLine());
        
        int horasMinutos = minutos * horas;

        Console.WriteLine($"{horas}Horas tem {horasMinutos} minutos!");
    }
}
