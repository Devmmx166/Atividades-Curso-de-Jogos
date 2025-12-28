namespace AT07;

class Program
{
    static void Main(string[] args)
    {
       double pi = 3.14159; 
       Console.WriteLine("Calcular area de um circulo");
       Console.WriteLine("-----------------------------");
       Console.WriteLine("Informe a area do circulo");
       double area = Convert.ToDouble(Console.ReadLine());

       double areaCirculo = pi * (area * area);
       
       Console.WriteLine($"O valor do circulo é: {areaCirculo}");
        
    }
}
