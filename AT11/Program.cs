namespace AT11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcular valor do salario!");

        Console.Write("Informe o valor pago por hora trabalhada:");
        float valorHora = float.Parse(Console.ReadLine());
        Console.Write("Infome as horas trabalhadas:");
        float horasTrabalhadas = float.Parse(Console.ReadLine());

        float salarioSemanal = valorHora * horasTrabalhadas; 
        float salariomensal = salarioSemanal * 4;

        Console.WriteLine($"O valor Semanal é: {Math.Round(salarioSemanal,2)} e mensal é {Math.Round(salariomensal,2)}");
        
        // Random roll = new Random();
        // int numerogerado = roll.Next(100);// gera entre 0 a 100
       // int numerogerado = roll.Next(1,11);// gera entre 1 a 10
        // Console.WriteLine(numerogerado);
    }
}
