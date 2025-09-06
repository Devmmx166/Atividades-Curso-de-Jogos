namespace At006;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Informe a sua altura: ");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe o seu peso: ");
    float peso = float.Parse(Console.ReadLine());
    float imc = peso / (altura * altura);
    Console.WriteLine($"Seu IMC é: {imc}");
    }
}
