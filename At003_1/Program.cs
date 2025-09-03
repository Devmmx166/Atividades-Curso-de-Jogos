namespace At003_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número:");
        float numero = float.Parse(Console.ReadLine());

        Console.WriteLine($"Informe um segundo número:");
        float numero2 = float.Parse(Console.ReadLine());

        float soma = numero + numero2;
        float subtracao = numero - numero2;
        float multiplicacao = numero * numero2;
        float divisao = numero / numero2;
        float restoDivisao = numero % numero2;


        Console.WriteLine($"A soma dos números {numero} e {numero2} é: {soma}");
        Console.WriteLine($"A subtração dos números {numero} e {numero2} é: {subtracao}");
        Console.WriteLine($"A multiplicação dos números {numero} e {numero2} é: {multiplicacao}");
        Console.WriteLine($"A divisão dos números {numero} e {numero2} é: {divisao}");
        Console.WriteLine($"O resto da divisão dos números {numero} e {numero2} é: {restoDivisao}");


    }
}
