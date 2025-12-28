namespace AT06;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Calculo IMC.");
    Console.WriteLine("Informe sua altura:");
    float altura = float.Parse(Console.ReadLine());
    Console.Write("Informe o seu  peso: ");
    float peso = float.Parse(Console.ReadLine());

    float imc = peso/(altura*altura);
    Console.WriteLine("Imc: " + imc);
    }
}
