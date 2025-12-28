namespace AT04;

class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("Media Aluno");
     Console.WriteLine("Informe a nota da primeira unidade: ");
     float nota01 = float.Parse(Console.ReadLine());
     Console.WriteLine("Informe a nota da segunda unidade: ");
     float nota02 = float.Parse(Console.ReadLine());
     Console.WriteLine("Informe a nota da terceira unidade: ");
     float nota03 = float.Parse(Console.ReadLine());
     Console.WriteLine("Informe a nota da quarta unidade: ");
     float nota04 = float.Parse(Console.ReadLine());

     float media = (nota01 + nota02 + nota03 + nota04)/4;

     Console.WriteLine($"A media do aluno é {media}");
    }
}
