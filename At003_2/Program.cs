namespace At003_2;

class Program
{
    static void Main(string[] args)
    {
        int ano = 360;
        Console.WriteLine("Digite sua Idade: ");
        int idade = int.Parse(Console.ReadLine());
        int idadeDias = idade * ano;
        Console.WriteLine($"Sua idade em dias é: {idadeDias} dias");
    }
}
